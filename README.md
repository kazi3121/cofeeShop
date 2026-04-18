# ☕ Coffee Shop System (C# + ADO.NET)

A simple console-based Coffee Shop Management System built using **C#**, **ADO.NET**, and **SQL Server**.  
This project demonstrates the use of **Design Patterns**, **Database Operations**, and **Clean Architecture principles**.

---

## 🚀 Features

- Coffee ordering system with dynamic customization
- Add-ons support using Decorator Pattern (Milk, Sugar, etc.)
- Discount calculation using Strategy Pattern
- Invoice generation using Adapter Pattern
- Full CRUD operations with SQL Server (ADO.NET)
- Order tracking and update functionality

---

## 🧠 Design Patterns Used

- **Factory Pattern** → Used to create different types of coffee (Espresso, etc.)
- **Decorator Pattern** → Used to add extra features like Milk and Sugar
- **Strategy Pattern** → Used for dynamic discount calculation (e.g., Happy Hours)
- **Adapter Pattern** → Used to integrate legacy invoice system with modern interface
- **Singleton Pattern** → Used for database connection management

---

## 🛠️ Tech Stack

- C# (.NET Console Application)
- ADO.NET
- Microsoft SQL Server

---

## 🗄️ Database Operations

The system performs:
- Insert new orders
- Update existing orders
- Retrieve all order history

Example table: `Orders`

---

## 📂 Project Structure

- Models → Coffee models and interfaces  
- Patterns → Factory, Strategy, Adapter, Decorators  
- Program.cs → Main execution logic  
- SqlDbConnection → Singleton database connection class  

---

## ▶️ How to Run

1. Clone the repository
   ```bash
   git clone https://github.com/your-username/coffee-shop-system.git
