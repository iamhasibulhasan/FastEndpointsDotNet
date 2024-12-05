# FastEndpointsDotNet - Clean Architecture with CQRS in .NET Core 9

Welcome to the **FastEndpointsDotNet** repository! This project demonstrates a modern, scalable, and maintainable solution using **.NET Core 9**, **Clean Architecture**, and the **CQRS** pattern. It features **FastEndpoints** for minimal API design, **PostgreSQL** with **Entity Framework**, and **AutoRegisterDI** for simplified dependency injection.

**Repo Link**: [FastEndpointsDotNet](https://github.com/iamhasibulhasan/FastEndpointsDotNet.git)

---

## 🚀 **Key Technologies**
- **.NET Core 9** & **C# 13**
- **Clean Architecture** principles
- **CQRS (Command Query Responsibility Segregation) pattern**
- **FastEndpoints** for minimal API design
- **PostgreSQL** with **Entity Framework** for data management
- **AutoRegisterDI** for automatic dependency injection registration

---

## 📂 **Project Structure**

```plaintext
📦 ProjectRoot
├── 📁 Core
│   ├── 📁 FastEndpointsDotNet.Application      # Business Logic (CQRS Handlers)
│   ├── 📁 FastEndpointsDotNet.Domain           # Core Entities & Interfaces
│   └── 📁 FastEndpointsDotNet.Infrastructure   # Data Access (EF Core, PostgreSQL)
└── 📁 Web.Api
    └── 📁 FastEndpointsDotNet.Api              # FastEndpoints (API Layer)
