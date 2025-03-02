# CRUD Operations in ASP.NET Core MVC

This project demonstrates the implementation of CRUD (Create, Read, Update, Delete) operations for an Employee model in an ASP.NET Core MVC application.

## Features
- Employee Management (Add, View, Edit, Delete)
- Entity Framework Core for Database Access
- MVC Pattern Implementation
- Proper Routing and Validation
- GitHub Submission via SourceTree

## Project Structure
```
/EmployeeCRUD
│── /Controllers
│   ├── EmployeeController.cs
│── /Models
│   ├── Employee.cs
│── /Data
│   ├── AppDbContext.cs
│── /Views
│   ├── Employee
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Delete.cshtml
│── Program.cs
│── appsettings.json
│── README.md
```

## Implementation
### 1. Create the Model (Employee.cs)
- Define an `Employee` class with properties:
  - `Id` (int, primary key)
  - `Name` (string, required, max length constraint)
  - `Position` (string, required)
  - `Salary` (double, required, range constraint)
- Use Data Annotations for validation.

### 2. Create the Database Context (AppDbContext.cs)
- Configure `AppDbContext` using Entity Framework Core.
- Add `DbSet<Employee>` to manage Employee entities.

### 3. Modify the Controller (EmployeeController.cs)
- Implement CRUD actions: `Index`, `Create`, `Edit`, and `Delete`.
- Use Dependency Injection to access the database.

### 4-7. Create Views for CRUD Operations
- `Index.cshtml`: List employees.
- `Create.cshtml`: Form to add a new employee.
- `Edit.cshtml`: Form to update employee details.
- `Delete.cshtml`: Confirmation page before deleting an employee.

### 8. Update Routes in Program.cs
- Ensure proper routing is configured.

### 9. Run & Test the Application
- Verify that all CRUD operations work correctly.
- Handle validation errors appropriately.

## Setup Instructions
### Prerequisites
- .NET 6 SDK or later
- Visual Studio 2022 or later
- SQL Server (LocalDB or another SQL provider)
- SourceTree installed

### Installation Steps
1. Clone the repository:
   ```sh
   git clone <repository_url>
   cd EmployeeCRUD
   ```
2. Install dependencies:
   ```sh
   dotnet restore
   ```
3. Apply migrations to set up the database:
   ```sh
   dotnet ef database update
   ```
4. Run the application:
   ```sh
   dotnet run
   ```

### GitHub Submission Instructions
1. Open SourceTree and clone the repository.
2. Commit and push changes to GitHub.
3. Submit the GitHub repository link.

## License
This project is for educational purposes only.


