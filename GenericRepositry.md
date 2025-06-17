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
