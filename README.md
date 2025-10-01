# Clean Architecture API Template

A .NET 10 REST API template following Clean Architecture principles, designed to accelerate the development of well-structured ASP.NET Core APIs.

## Overview

This template provides a solid foundation for building REST APIs with Clean Architecture, ensuring separation of concerns, testability, and maintainability from the start.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later

## Installation

### Step 1: Clone the Repository

Since this is a private template, you'll need to clone the repository first:

```bash
git clone https://github.com/joabealexandre/Clean_Arch_AspNet_API_Template.git
cd Clean_Arch_AspNet_API_Template
```

### Step 2: Install the Template

Install the template locally using the .NET CLI:

```bash
dotnet new install .
```

To verify the installation, list all installed templates:

```bash
dotnet new list
```

You should see **Clean Architecture API** with the short name **clean-arch-api** in the list.

## Usage

### Creating a New Project

Navigate to the directory where you want to create your new project and run:

```bash
dotnet new clean-arch-api -n YourProjectName
```

This will create a new solution with the Clean Architecture structure using your specified project name.

### Example Commands

**Create a project named "TaskManager":**
```bash
dotnet new clean-arch-api -n TaskManager
```

**Create a project in a specific directory:**
```bash
dotnet new clean-arch-api -n ECommerce -o ./src/ECommerce
```

**Create a project in the current directory:**
```bash
mkdir MyAwesomeAPI
cd MyAwesomeAPI
dotnet new clean-arch-api -n MyAwesomeAPI
```

### Post-Creation Steps

After generating your project:

1. **Navigate to the project directory:**
   ```bash
   cd YourProjectName
   ```

2. **Restore NuGet packages:**
   ```bash
   dotnet restore
   ```

3. **Build the solution:**
   ```bash
   dotnet build
   ```

4. **Run the API:**
   ```bash
   dotnet run --project src/YourProjectName.API
   ```

## Template Information

- **Author:** Joabe Leite
- **Classifications:** Web, ASP.NET, Clean Architecture, API
- **Language:** C#
- **Type:** Project Template

## Uninstalling the Template

If you need to remove the template:

```bash
dotnet new uninstall Clean.Arch.API
```

Or specify the full path where you installed it from:

```bash
dotnet new uninstall /path/to/Clean_Arch_AspNet_API_Template
```

## Updating the Template

To update to the latest version:

1. Pull the latest changes from the repository:
   ```bash
   cd /path/to/Clean_Arch_AspNet_API_Template
   git pull origin main
   ```

2. Reinstall the template:
   ```bash
   dotnet new install . --force
   ```

## Support

For issues, questions, or contributions, please visit the [GitHub repository](https://github.com/joabealexandre/Clean_Arch_AspNet_API_Template).

## License

Please refer to the LICENSE file in the repository for licensing information.