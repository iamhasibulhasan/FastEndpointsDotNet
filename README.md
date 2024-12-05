# FastEndpointsDotNet

## 🚀 **Overview**
This project demonstrates a Clean Architecture setup with **CQRS** pattern, utilizing **FastEndpoints**, **MediatR**, **FluentValidation**, **PostgreSQL**, and **Entity Framework Core**. It's built using **.NET 9** and **C# 13**, with auto-registration of services through the `AutoRegisterDI` package.

## 🚀 **Clone Repo**
git clone https://github.com/iamhasibulhasan/FastEndpointsDotNet.git


## 📦 **Features**
- **Clean Architecture**: Maintains separation of concerns and ensures scalability.
- **CQRS Pattern**: Implements Command and Query Responsibility Segregation.
- **FastEndpoints**: Simplified API layer to handle HTTP requests and responses.
- **MediatR**: Decouples the request/response logic from application layers.
- **FluentValidation**: Provides a fluent interface for validating objects and requests.
- **PostgreSQL**: Utilizes PostgreSQL for data storage and management.
- **Entity Framework Core**: Handles data access and database management.
- **AutoRegisterDI**: Automatically registers services for dependency injection.

## 📂 **Project Structure**

```plaintext
📦 ProjectRoot
├── 📁 Core
│   ├── 📁 FastEndpointsDotNet.Application      # Business Logic (CQRS Handlers, MediatR)
│   ├── 📁 FastEndpointsDotNet.Domain           # Core Entities & Interfaces
│   └── 📁 FastEndpointsDotNet.Infrastructure   # Data Access (EF Core, PostgreSQL)
└── 📁 Web.Api
    └── 📁 FastEndpointsDotNet.Api              # FastEndpoints (API Layer)
