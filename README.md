

# **Clean Architecture Solution Template**

Welcome to the **Clean Architecture Solution Template**! This template is designed to help developers build scalable, maintainable, and testable applications following the principles of Clean Architecture.

## **Overview**

The Clean Architecture Solution Template provides a structured approach to software development that separates the core business logic from infrastructure concerns, ensuring that the application remains flexible, modular, and easy to maintain over time.

### **Layers in the Solution**

1. **Core/Domain Layer**:
   - Contains the core business logic and domain entities.
   - Represents the essential business rules and logic of the application.
   - Independent of external technologies like databases, UI frameworks, or APIs.

2. **Application Layer**:
   - Contains the application's use cases and logic.
   - Coordinates between the domain and infrastructure layers.
   - Defines application services, commands, and queries.

3. **Infrastructure Layer**:
   - Responsible for external services, such as databases, file systems, and third-party APIs.
   - Implements repository patterns and handles data access and persistence.
   - Can be replaced without affecting the core business logic.

4. **Presentation Layer**:
   - The entry point for user interaction, often implemented as a Web API or a UI project.
   - Handles requests from clients (e.g., HTTP, web, or mobile apps) and communicates with the application layer.

## **Getting Started**

### **Pre-requisites**

Before using this template, ensure you have the following installed on your system:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [Visual Studio Code](https://code.visualstudio.com/)

### **Installation**

To install the template:

1. Clone the repository or download the solution:
   ```bash
   git clone https://github.com/your-username/CASolution.CleanArchitecture.Template.git
   ```

2. Open the solution in **Visual Studio** or your preferred IDE.

3. Restore dependencies and build the solution:
   ```bash
   dotnet restore
   dotnet build
   ```

### **Usage**

Once installed, you can scaffold new solutions using this template:

```bash
dotnet new cleanarch -n YourProjectName
```

This will generate a new solution based on the **Clean Architecture Solution Template**.

## **Folder Structure**

- `src/YourSolution.Domain`: Core domain layer containing business logic and entities.
- `src/YourSolution.Application`: Application layer for use cases, services, and DTOs.
- `src/YourSolution.Infrastructure.Services`: Services project for infrastructure layer.
- `src/YourSolution.Infrastructure.Psersistence`:Data Persistence for Infrastructure layer.
- `src/YourSolution.API`: API Configs.
- `src/YourSolution.Presentation`: Presentation layer as an ASP.NET Core Web API.
- `src/YourSolution.Contract`: Contracts for Responses / Requests.
- `src/YourSolution.API`: Presentation layer as an ASP.NET Core Web API.
- 

## **Contributing**

Contributions are welcome! Feel free to open issues or submit pull requests if you have suggestions, improvements, or bug fixes.

1. Fork the repository.
2. Create a feature branch:
   ```bash
   git checkout -b feature/your-feature
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add your feature description"
   ```
4. Push the branch:
   ```bash
   git push origin feature/your-feature
   ```
5. Open a pull request on GitHub.

## **License**

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for more details.
