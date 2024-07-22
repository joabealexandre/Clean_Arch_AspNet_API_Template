# Clean Arch API

This is my Clean Architecure API with ASP.NET Core template.

## Prerequisites

Before trying to run the project locally, make sure you install the following:

- .NET 8 SDK
- Visual Studio Code

### VS Code Extensions

[C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) [Required]

### Running Locally

Launch the app in debug mode by selecting Run -> Start Debugging (or by pressing F5).

### Database

We use PostgreSQL as relational database. Update connection string in `appsettings.json` file.

### Todo Use Cases

As a sample, we have some Use Cases that handle Todos requests. It's only for reference about how to implement code.

### Tests

We are using xUnit as test library. The tests projects can be created following the pattern `<project-name>.<type>`. For example:

- CleanArchApi.Application.UnitTests
- CleanArchApi.Application.IntegrationTests
- CleanArchApi.Domain.UnitTests

### Technologies

- ASP.NET 8 _#TODO_
- Entity Framework _#TODO_
- [MediatR](https://github.com/jbogard/MediatR)
- [FluentValidation](https://github.com/FluentValidation)
- [XUnit](https://xunit.net/)

### References

- [jasontaylordev](https://github.com/jasontaylordev/CleanArchitecture/tree/main)
- [ardalis](https://github.com/ardalis/CleanArchitecture/tree/main)
- [Debugging](https://jasonwatmore.com/post/2021/06/24/vs-code-net-debug-a-net-web-app-in-visual-studio-code)