using Microsoft.SemanticKernel;
using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace GloboTicket.Frontend.Services.AI;

public static class TelemetryExtensions
{
    public static IKernelBuilder UseTelemetry(this IKernelBuilder builder, string serviceName, IConfiguration configuration)
    {
        // WARNING: This switch exposes PII to the telemetry collection system.
        AppContext.SetSwitch("Microsoft.SemanticKernel.Experimental.GenAI.EnableOTelDiagnosticsSensitive", true);

        var otlpEndpoint = configuration["OTEL_EXPORTER_OTLP_ENDPOINT"];
        var useOtlpExporter = !string.IsNullOrWhiteSpace(otlpEndpoint);

        var resourceBuilder = ResourceBuilder
            .CreateDefault()
            .AddService(serviceName);

        // Register TracerProvider factory
        builder.Services.AddSingleton(_ =>
        {
            var tracerProviderBuilder = Sdk.CreateTracerProviderBuilder()
                .SetResourceBuilder(resourceBuilder)
                .AddSource("Microsoft.SemanticKernel*");

            if (useOtlpExporter)
            {
                tracerProviderBuilder.AddOtlpExporter(exporter =>
                {
                    exporter.Endpoint = new Uri(otlpEndpoint!);
                });
            }
            else
            {
                tracerProviderBuilder.AddConsoleExporter();
            }

            return tracerProviderBuilder.Build();
        });

        // Register MeterProvider factory
        builder.Services.AddSingleton(_ =>
        {
            var meterProviderBuilder = Sdk.CreateMeterProviderBuilder()
                .SetResourceBuilder(resourceBuilder)
                .AddMeter("Microsoft.SemanticKernel*");

            if (useOtlpExporter)
            {
                meterProviderBuilder.AddOtlpExporter(exporter =>
                {
                    exporter.Endpoint = new Uri(otlpEndpoint!);
                });
            }
            else
            {
                meterProviderBuilder.AddConsoleExporter();
            }

            return meterProviderBuilder.Build();
        });

        // Configure logging
        builder.Services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddOpenTelemetry(options =>
            {
                options.SetResourceBuilder(resourceBuilder);

                if (useOtlpExporter)
                {
                    options.AddOtlpExporter(exporter =>
                    {
                        exporter.Endpoint = new Uri(otlpEndpoint!);
                    });
                }
                else
                {
                    options.AddConsoleExporter();
                }

                options.IncludeFormattedMessage = true;
                options.IncludeScopes = true;
            });
            
            loggingBuilder.SetMinimumLevel(LogLevel.Trace);
        });

        return builder;
    }
}