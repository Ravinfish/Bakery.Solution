#  Bakery

#### By Ravin Fisher

#### Code Review for Epicodus. A C# console application using TDD with MSTest showcasing use of  Classes, Namespaces, auto-implemented properties and methods.

## Technologies Used

* TDD
* MSTest
* C#
* RGR Workflow
* .Net
* Git

## Description

This is a console application that will allow you to purchase either bread or a pastries and calcualte a price based off of quantity. Bread has a deal of buy 2 get one free and Pastry has a deal of buy 3 get one free.

## Setup/Installation Requirements

_This is a basic console application, not viewable on gh-pages. Please follow steps below to set up locally_

1. Navigate to [my github repository](https://github.com/Ravinfish/Bakery.Solution.git) for this project 

2. Click the `Fork` button and  you will be taken to a new page where you can give your repository a new name and description. Choose "create fork".
. On your terminal, type `$ git clone 'url'` (using the url from step 3.)

6. Once you have this on your local directory, if you ever want to push it to GitHub, you need to do these steps first so Git knows to ignore the obj and bin directories:

* git init` to initialize Git (if cloning, this step automatically happened)
* touch .gitignore` adds .gitignore file in the root directory. add bin and obj to this file and save.
* git add .gitignore`
* git commit -m 'add .gitignore`
* git push origin main`

7. On your terminal, type `$ code .` to open in VS Code.  If you do not have VS Code Editor, you may download [here](https://code.visualstudio.com/)
8. Once in VS Code, open the terminal and navigate to the project's production directory called "Bakery" and type `$ dotnet build` to compile the application's code.
9.  To use MSTest, you need to use the NuGet package manager to install the packages in the .csproj file.  Navigate to the Bakery.Tests directory in the terminal and run the command `$ dotnet restore`

9.  Optionally you can use a file watcher so you don't have to restart the server every time the code changes. Run this command `$ dotnet watch run` to make the server automatically update.

## Known Bugs

## License

Copyright (c) January 2024 Ravin Fisher