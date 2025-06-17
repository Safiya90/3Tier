# 🗃️ Generic Repository Pattern in ASP.NET Core

The **Generic Repository Pattern** is a widely used design pattern in ASP.NET applications. It provides a reusable and consistent way to handle data access logic across multiple entities, promoting clean architecture and separation of concerns.

---

## 🎯 Purpose of This Repository

This project includes a **practical implementation** of the Generic Repository Pattern using **ASP.NET Core** and **Entity Framework Core**.

> 🔍 **You can check out the working example in this repository to see how it's implemented in a real-world scenario.**

---

## 🧱 What Is the Generic Repository Pattern?

A generic repository abstracts common data access operations (CRUD) into a single reusable component that can work with any entity.

Instead of writing a separate repository for every entity, you define a generic version like this:

### 🧩 Generic Interface

```csharp
public interface IRepository<T> where T : class
{
    T GetById(int id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}


---

## ✅ Advantages

| 💡 Feature               | 📌 Description                                           |
|-------------------------|----------------------------------------------------------|
| ♻️ Reusable Code         | One repository handles all entities.                    |
| 🧼 Clean Architecture    | Promotes separation of concerns.                        |
| 🔄 DRY Principle         | Avoid code duplication in data access logic.           |
| 🧪 Easy to Test          | Interface-based design enables mocking in unit tests.  |

---

## 📦 Technologies Used

- ✅ ASP.NET Core
- ✅ Entity Framework Core
- ✅ Dependency Injection
- ✅ LINQ


---

## 👨‍💻 Author's Note

I created this example to demonstrate how to implement and use the **Generic Repository Pattern** effectively in ASP.NET Core projects.  
Feel free to explore the code, fork the repo, and adapt it to your own applications.

> 💬 If you find it helpful, consider starring ⭐ the repo or leaving feedback!

---

