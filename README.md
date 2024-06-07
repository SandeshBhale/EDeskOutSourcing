# E-Desk Outsourcing Application

## Project Description
E-Desk Outsourcing is a web portal designed to facilitate outsourcing of work (design, development) from companies to engineers or freelancers. The platform allows companies to post jobs, manage work processes, and interact with freelancers who can search and apply for jobs. The application includes roles for Admin, Company, Freelancer, and general web portal functionalities.

## Features
- **Role-based authorization**
- **Data segregation**
- **Separation of concerns**
- **Implementation of design patterns**:
  - Repository Pattern: Enhances data access structuring by abstracting data logic into repositories, ensuring consistent and maintainable operations across the application. Integrated with ASP.NET Core's Dependency Injection framework for flexible and modular development.

### Stakeholders
- **Admin**: Manages terms and conditions, user activation/deactivation, and master management.
- **Company**: Handles work management, candidate profiles, work reports, and freelancer interactions.
- **Freelancer**: Manages profiles, searches for work, applies for jobs, handles work assignments, and resolves queries.
- **Web Portal**: Displays work details with options for searching, filtering, forwarding, and displaying the latest jobs.

## Installation Instructions
1. **Editors**: Visual Studio 2022, SQL Server Management Studio 19
2. **Versions**:
   - .NET Core: ASP.NET Core 6
   - Bootstrap: Bootstrap 5
3. **Packages**:
   - Microsoft.EntityFrameworkCore 7.0.18
   - Microsoft.EntityFrameworkCore.Proxies 7.0.18
   - Microsoft.EntityFrameworkCore.Relational 7.0.18
   - Microsoft.EntityFrameworkCore.SQLServer 7.0.18

### Steps
1. Clone the repository:
    ```sh
    git clone https://github.com/your-repo/E-Desk-Outsourcing.git
    ```
2. Navigate to the project directory:
    ```sh
    cd E-Desk-Outsourcing
    ```
3. Open the solution file in Visual Studio 2022.
4. Restore the NuGet packages:
    ```sh
    dotnet restore
    ```
5. Update the database connection string in `appsettings.json`.
6. Apply migrations to set up the database:
    ```sh
    dotnet ef database update
    ```
7. Run the application:
    ```sh
    dotnet run
    ```

## Usage Instructions
1. **Admin**:
   - Define terms and conditions.
   - Activate/deactivate users.
   - Manage master settings.
2. **Company**:
   - Register, login, logout, change password.
   - Post work, manage budget, and schedule.
   - Define work steps and payment schedules.
   - Manage work documents and candidate profiles.
   - View work reports, generate conflicts.
   - Resolve freelancer queries and close work.
3. **Freelancer**:
   - Register, login, change password.
   - Manage profile, education, skills, and experience.
   - Create/manage work gallery, search/apply for work.
   - View assigned works, and reports.
   - Generate work reports, handle payments, and resign from work.
   - Ask queries and view solutions.
4. **Web Portal**:
   - Display all work details with search, filter, and forwarding options.
   - Show latest works.

## Technologies Used
- **ASP.NET Core 6**
- **Entity Framework Core**
- **Bootstrap 5**
- **JavaScript**

## Contact Information
For any queries or issues, please contact us at:
- **Email**: sandesh.bhale.work@gmail.com