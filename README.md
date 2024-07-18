# Clean Arch API

This is my Clean Architecure API with ASP.NET Core template.

We are using:

- .NET 8
- EF Core

### Prerequisites

Before trying to run the project locally, make sure you install the following:
- .NET 8 SDK
- Visual Studio Code

#### VS Code Extensions

[C# ](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)[Required]

### Running Locally

#### Generating assets

After opening the project in VS Code you should see a popup alert from the C# extension with the message - Required assets to build and debug are missing from 'VAR'. Add them? - click Yes to automatically generate the launch.json and tasks.json files in the .vscode folder with the required configuration to build and debug the project.

Alternatively you can generate the tasks.json and launch.json files with these steps:

Select Run and Debug on the side bar (or press Ctrl + Shift + D)
Click create a launch.json file
Select environment: .NET Core
#### Running

Launch the app in debug mode by selecting Run -> Start Debugging (or by pressing F5).


### Technologies

* [MediatR](https://github.com/jbogard/MediatR)
* [FluentValidation](https://github.com/FluentValidation)


### References

- [jasontaylordev](https://github.com/jasontaylordev/CleanArchitecture/tree/main)
- [ardalis](https://github.com/ardalis/CleanArchitecture/tree/main)
- [Debugging](https://jasonwatmore.com/post/2021/06/24/vs-code-net-debug-a-net-web-app-in-visual-studio-code)