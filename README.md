Product Management API (Clean Architecture)

📌 Introduction

This is a backend project for simple product management using Clean Architecture principles. It provides CRUD operations for managing products in a structured and scalable way.

🏗️ Architecture Overview

This project follows the Clean Architecture approach, separating concerns into different layers:

Domain Layer: Contains core business logic and entities.

Application Layer: Includes use cases and service logic.

Infrastructure Layer: Handles database operations and external dependencies.

Presentation Layer: API controllers to expose endpoints.

🛠️ Technologies Used

.NET 8

ASP.NET Core Web API

Entity Framework Core

MediatR (for CQRS pattern)

FluentValidation (for request validation)

Swagger UI (for API documentation)

Docker (for containerization)

SQL Server (as the database)

🚀 Getting Started

1️⃣ Prerequisites

.NET 8 SDK

Docker (optional for running SQL Server)

SQL Server

2️⃣ Clone the Repository

git clone [[https://github.com/your-username/your-repo-name](https://github.com/haindvn8386/CleanArchitecture.git)](https://github.com/haindvn8386/CleanArchitecture.git)
cd your-repo-name

3️⃣ Configure the Database

Update appsettings.json with your SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ProductDb;User Id=sa;Password=your_password;"
}

Run database migrations:

dotnet ef database update

4️⃣ Run the Application

dotnet run

5️⃣ API Documentation

Open Swagger UI: http://localhost:5000/swagger

📌 API Endpoints

| Method | Endpoint         | Description                     |
|--------|------------------|---------------------------------|
| GET    | /api/products    | Get all products                |
| GET    | /api/products/:id| Get single product              |
| POST   | /api/products    | Create new product              |
| PUT    | /api/products/:id| Update product                  |
| DELETE | /api/products/:id| Delete product                  |

🏆 Features

✅ Clean Architecture for maintainability
✅ CQRS pattern with MediatR
✅ FluentValidation for request validation
✅ Swagger UI for API testing
✅ Docker support for easy deployment
✅ SQL Server with Entity Framework Core

🛠 Contributing

Feel free to contribute by submitting issues or pull requests.

📄 License

This project is licensed under the MIT License.
