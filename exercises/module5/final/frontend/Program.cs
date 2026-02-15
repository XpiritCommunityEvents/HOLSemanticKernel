using GloboTicket.Frontend.Services;
using GloboTicket.Frontend.Models;
using GloboTicket.Frontend.Services.Ordering;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Prometheus;
using HealthChecks.UI.Client;
using GloboTicket.Frontend.HealthChecks;
using Microsoft.Extensions.Options;
using GloboTicket.Frontend.Services.AI;
using Wolverine;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseWolverine(opts =>
{
    // Sample setup for asynchronous message handling with Wolverine
    // You can also use other frameworks like Dapr, MassTransit, NServiceBus, or MediatR

    opts.Policies.UseDurableLocalQueues();
    opts.Durability.KeepAfterMessageHandling = TimeSpan.FromHours(1);
    opts.LocalQueue("llmqueue").UseDurableInbox();
});

// Add services to the container.
builder.Services.AddControllersWithViews();

// note: for this demo we're using the DAPR_HTTP_PORT environment variable to decide if we're using Dapr or not
builder.Services.AddHttpClient<IEventCatalogService, EventCatalogService>((sp, c) =>
{
    c.BaseAddress = new Uri(sp.GetService<IConfiguration>()["ApiConfigs:EventCatalog:Uri"]);
});
builder.Services.AddHttpClient<IOrderSubmissionService, HttpOrderSubmissionService>((sp, c) =>
{
    c.BaseAddress = new Uri(sp.GetService<IConfiguration>()["ApiConfigs:Ordering:Uri"]);
});

builder.Services.AddSingleton<IShoppingBasketService, InMemoryShoppingBasketService>();
builder.Services.AddSingleton<Settings>();

builder.Services.AddHealthChecks()
   .AddCheck<SlowDependencyHealthCheck>("SlowDependencyDemo", tags: new string[] { "ready" })
   .AddProcessAllocatedMemoryHealthCheck(maximumMegabytesAllocated: 500);

builder.Services.AddHttpClient(Options.DefaultName)
    .UseHttpClientMetrics();

builder.Services.AddSingleton<Settings>();

builder.Services.AddSignalR();

await builder.Services.AddSemanticKernelServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

// Turning this off to simplify the running in Kubernetes demo
// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapHub<ChatHub>("/chatHub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=EventCatalog}/{action=Index}/{id?}");

//map the livelyness and readyness probes
app.MapHealthChecks("/health/ready",
new HealthCheckOptions()
{
    Predicate = reg => reg.Tags.Contains("ready"),
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.MapHealthChecks("/health/lively",
new HealthCheckOptions()
{
    Predicate = reg => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.UseHttpMetrics();
app.UseMetricServer();

app.MapMetrics();

await app.RunAsync();
