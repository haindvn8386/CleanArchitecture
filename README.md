# Product & Order Microservices API

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)
![Microservices](https://img.shields.io/badge/Architecture-Microservices-brightgreen)
![Docker](https://img.shields.io/badge/Docker-Enabled-blue)
![Kafka](https://img.shields.io/badge/Kafka-EventDriven-orange)
![License](https://img.shields.io/badge/License-MIT-yellow)

A modern **Product & Order Management API** built with **.NET 8** using **Microservices Architecture**. This project showcases a scalable and distributed back-end system for managing products and orders, leveraging **Docker** for containerization and **Apache Kafka** for event-driven communication. Hosted on GitHub as part of my portfolio, it demonstrates my expertise in microservices design, containerization, and asynchronous messaging.

## ☸️Table of Contents
- [Project Overview](#project-overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Architecture](#architecture)
- [Setup Instructions](#setup-instructions)
- [API Endpoints](#api-endpoints)
- [How to Run](#how-to-run)
- [Docker & Kafka Configuration](#docker--kafka-configuration)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## 🏗️Project Overview
This is a back-end project designed as a microservices-based system for managing **products** and **orders**. It consists of two main services: **Product Service** and **Order Service**, communicating asynchronously via Kafka. The project uses .NET 8, Docker for containerization, and SQLite as a lightweight database (configurable for other DBMS). It’s a practical example of modern distributed systems, built to highlight my skills in microservices architecture and DevOps practices.

Goals of this project:
- Demonstrate proficiency in designing and implementing microservices.
- Showcase integration of event-driven architecture with Kafka.
- Highlight containerization skills using Docker.

## 🛠️Features
- **Product Service**: CRUD operations for managing products.
- **Order Service**: Create and retrieve orders, linked to products.
- **Event-Driven Communication**: Uses Kafka to publish and consume events (e.g., order creation triggers stock updates).
- **Containerization**: Services run in Docker containers for easy deployment.
- **Scalability**: Microservices architecture enables independent scaling of services.

## 🗝️Technologies Used
- **.NET 8.0**: Core framework for building microservices.
- **ASP.NET Core**: RESTful API framework for each service.
- **Entity Framework Core**: ORM for database operations.
- **SQLite**: Lightweight database (swappable to SQL Server, PostgreSQL, etc.).
- **Docker**: Containerization of services.
- **Apache Kafka**: Message broker for event-driven communication.
- **Confluent.Kafka**: .NET client for Kafka integration.
- **Swagger**: API documentation and testing.

## 🏚️Architecture
The project follows **Microservices Architecture** with the following components:
- **Product Service**: Manages product data (e.g., name, price, stock). Publishes events to Kafka when product stock changes.
- **Order Service**: Handles order creation and retrieval. Consumes events from Kafka to update order status based on product availability.
- **Kafka**: Acts as the message broker for asynchronous communication between services. Topics: `product-stock-updated`, `order-created`.
- **Docker**: Each service runs in its own container, alongside Kafka and Zookeeper.

This architecture ensures loose coupling, scalability, and fault tolerance.

## 💽Setup Instructions
### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [Git](https://git-scm.com/)
- Optional: [Visual Studio 2022](https://visualstudio.microsoft.com/)

### Configure the Database
Update appsettings.json with your SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ProductDb;User Id=sa;Password=your_password;"
}

### Run database migrations:

dotnet ef database update

### Run the Application

dotnet run

### 📖API Documentation

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


### 🐰Cloning the Repository
git clone https://github.com/haindvn8386/CleanArchitecture.git
cd CleanArchitecture


## 🛠 Contributing

Feel free to contribute by submitting issues or pull requests.

## 📄 License

This project is licensed under the MIT License.
