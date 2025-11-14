# Lab 0.3 - Familiarizing with GloboTicket
In this lab you are going to familiarize yourself with the existing GloboTicket application. It is a .NET application that consists of three main parts:

1. Frontend: ASP.NET Core MVC web application that uses Razor pages to build a UI
2. Catalog: ASP.NET Core Web API offering the catalog of event tickets
3. Ordering: a background service that processes orders from the frontend

## Examine starter application
Whichever environment you have, now would be a good time to familiarize yourself with the code of the starter application. You can examine the code files and try to understand how things work.

## Running from GitHub Codespaces
You can use GitHub Codespaces to run your development machine from the cloud. This way you do not have to setup anything on your development machine other than a modern browser. 

If you followed the instructions in Lab 0 you should have a running codespace to get started. Once your codespace has opened, you will see a browser-based IDE that closely resembles Visual Studio Code. 

The Globoticket application consists of a frontend and 2 backend services. IN order to see the data in the frontend, we use the catalog backend service. This service connects to a SQL Server Database that runs in a Docker container. 

To check if the database is correctly running, open a terminal window in the Codespace and execute the following command

```cmd
docker ps
```
you should see a running container for SQL Server as shown below:

```
marcelv/globoticket-default-db 
```

It sometimes happens, that the container stopped or did not run. If you do not see the container running, you can start it by executing the following command in the terminal window:

```cmd
docker run -d -p 1433:1433 marcelv/globoticket-default-db
```

### Starting the application
First we want to open the solution form the solutionexplorer to easily work with the Globoticket application. In the `src\Globoticket` folder you will find a `globoticket.sln` file. Right click this file and select `Open Solution` from the context menu.

In the solution folder you can then start the application. Right click the `catalog` project and select `Debug\Start without Debugging` from the context menu. Do the same for the `ordering` project.

## Exploring GloboTicket application
The homepage of the GloboTicket webshop shows three available events. 

<img src="https://user-images.githubusercontent.com/5504642/173662881-aa3f96ee-1cea-46a1-9427-6c80745dfbd9.png" width="700" />

Click around in the website and examine the events. Add whichever you like to your shopping basket.

<img src="https://user-images.githubusercontent.com/5504642/173662993-6785a470-94e9-41bf-820e-49eab80e35fd.png" width="500" />

When you have selected the events you want, you can go to the checkout of your order.

<img src="https://user-images.githubusercontent.com/5504642/173663055-acd8ec97-5743-40e4-8d1c-f913b0a22ab4.png" width="500" />

Fill in the details for your order. You can use a fictitious card number that passes the number check, such as 1111222233334444. Choose an expiry date in the future.

<img src="https://user-images.githubusercontent.com/5504642/173663097-8adf18a7-dc20-4c9c-acf1-30958bad82d4.png" width="500" />

After completing the order you should get a confirmation page.

<img src="https://user-images.githubusercontent.com/5504642/173663153-547ef3b5-177b-471e-8116-b2099e844256.png" width="300" />

Finally click the Chat button on top of the homepage. This will open up a simple chat window where you can interact with a chatbot. Onky the chatbot is quite limited at the moment. In the rest of the workshop we will use Semantic Kernel to enhance the chatbot experience. We will do exercises in simple console applications to get familiar with Semantic Kernel and then integrate the functionality in the GloboTicket application in the final lab.

## Finish lab
You are all done. You have given the GloboTicket application a spin. 

Stop running your application. In Visual Studio Code and GitHub CodeSpaces you can stop the composition by pressing Ctrl+C in the terminal window. 
