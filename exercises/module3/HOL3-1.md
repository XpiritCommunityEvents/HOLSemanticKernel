# Lab 3.1 - Using Agents

In this lab, we will explore the use of agents as a way to interact with LLM's.

## Create an Agent that can book rides

**Goal:** At the end of this lab, you should have an agent that can find affordable rides for you and can also book them at a booking provider.

> 👉🏻 We assume that you use a clean startup solution that we created that contains the boilerplate to get you started. You can find this in `HolSemanticKernel/exercises/module4/start`.

### Steps

1. Open the folder in your codespace and load the solution `module-agent-start.sln`:

In the solution you find two classes. `Program.cs`, which is the entrypoint of the console application and `ChatWithAgent.cs`
The `program.cs` is similar as in the other excersises where we create an instance of the class `ChatWithAgent` and we call the method we want to execute.

The boilerplate for the method `let_agent_find_ride` is created and you are now going to create an Agent to first have asimilar conversation as you had with the `IChatCompletion` interface in the previous excersises.

When you run the application the output should look as follows:
``` console
******** Create the kernel ***********
******** Create the agent ***********
******** Start the agent ***********
******** RESPONSE ***********
```

2. Create the semantic Kernel object, with the provided model, endpoint and apiKey.

>:warning: Since this is a new solution, you need to add the Api key to the user secret store again. The empty project, does not contain the api key yet.

This coude should be famiiar by now. You create the KernelBuilder, you create the credentials and then Add an `AIChatCompletion`endpoint to the `KernelBuilder`. Next you build the KernelBuilder and you now have your `Kernel` object.

The code should look as follows (Azure Open AI):
``` c#
 IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
 var credential = new AzureKeyCredential(apiKey);
 var client = new AzureOpenAIClient(new Uri(endpoint), credential);
 kernelBuilder.AddAzureOpenAIChatCompletion(deploymentName, client);
 Kernel kernel = kernelBuilder.Build();
```
Or it should look like this for OpenAI
``` c#
IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
kernelBuilder.AddOpenAIChatCompletion(deploymentName,new Uri(endpoint), apiKey);
Kernel kernel = kernelBuilder.Build();
```

