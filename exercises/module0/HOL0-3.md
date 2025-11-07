# Lab 0.3 - Familiarizing with GloboTicket
In this lab you are going to familiarize yourself with the existing GloboTicket application. It is a .NET application that consists of three main parts:

1. Frontend: ASP.NET Core MVC web application that uses Razor pages to build a UI
2. Catalog: ASP.NET Core Web API offering the catalog of event tickets
3. Ordering: a background service that processes orders from the frontend

## Examine starter application
Whichever environment you have, now would be a good time to familiarize yourself with the code of the starter application. You can examine the code files and try to understand how things work.

## Running from GitHub Codespaces
You can use GitHub Codespaces to run your development machine from the cloud. This way you do not have to setup anything on your development machine other than a modern browser. 

If you followed the instructions in Lab 0 you should have a running codespace to get started. Once your codespace has opened, you will see a browser-based IDE that closely resembles Visual Studio Code. You can inspect the code. Once you are ready to start the application, open a terminal window and execute 

```cmd
docker-compose up --build
```

You should see a window appear after starting the application composition using Docker-Compose Click the button in the popup to open the frontend on port 5001:

<img src="https://user-images.githubusercontent.com/5504642/173662514-8cf8bb49-f81b-4c6d-8b75-e7b988a4c1e2.png" width="400" />

If you miss the popup you can still see all the containers and exposed ports running by looking at the small dialog mentioning the exposed ports. You can rightclick urls in the local address column and select "open in browser" to view that container on that port in the browser.

<img src="https://user-images.githubusercontent.com/5504642/226200631-988f67bf-5a97-4903-9aa0-2af7fcc52b51.png" width="700" />

Continue in the section [Exploring GloboTicket application](#Exploring-Globoticket-Application).

## Working with Visual Studio 2022 or Visual Studio Code
If you are not using GitHub Codespaces you will probably use one of the available versions of Visual Studio to work with the code from your local file system. Make sure you have cloned the Git repository for GloboTicket. 

> #### Important!
> You must first checkout the `start` branch to get started with the following labs. The main branch has the full solution corresponding to the result of your work at the end of the workshop after having completed all labs. 

### Using Visual Studio 2022
Open the globoticket-dapr.sln solution file in Visual Studio 2022. You can inspect the solution as usual. 
Run the application by settings the Docker Compose project as the startup file and pressing F5.

The application should build the images and start the container composition using the `docker-compose.yml` and `docker-compose.override.yml` files. After a successful launch Visual Studio should open a browser automatically. If not, navigate to http://localhost:5001/. 

Continue in the section [Exploring GloboTicket application](https://github.com/XpiritCommunityEvents/DaprWorkshop/wiki/Lab-1:-Inspecting-GloboTicket#exploring-globoticket-application).
 
### Using Visual Studio Code
Open the root folder of the cloned repository in Visual Studio Code. You can run the application by opening a Terminal window and executing 
```cmd
docker-compose up --build
```
After the composition has started you should see a small dialog mentioning the exposed ports.

<img src="https://user-images.githubusercontent.com/5504642/173662780-e5b272fd-7872-45b0-836a-8c6334efb395.png" width="700" />

Right-click port 5001 for the frontend application and select `Open in Browser`. 
Your browser should open and display the homepage of GloboTicket.

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

> Pro tip! Leave this page open, so you can repeat the process of making a purchase without having to fill out the form every time. We will be purchasing a lot of tickets in this workshop.

Examine the logs for your application. Depending on the IDE you are using this will be different. Inspect the output. As an example, try and find the logging of the `ordering` service. After completing your order this should show something similar to this:

<img src="https://user-images.githubusercontent.com/5504642/173663203-68183dd0-6fef-44f6-a150-3ff0f369a6f1.png" width="500" />

## Finish lab
You are all done. You have given the GloboTicket application a spin. In the next lab you will start using Dapr by adding support in the application.

Stop running your application. In Visual Studio Code and GitHub CodeSpaces you can stop the composition by pressing Ctrl+C in the terminal window. 

<img src="https://user-images.githubusercontent.com/5504642/173663285-5882128d-08a0-48cc-989a-804047beff89.png" width="400" />

In Visual Studio 2022 you can press Shift+F5 or click on the red square stop icon in the Debug toolbar.
