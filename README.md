# 3-Tier Architecture in ASP.NET

## Overview

📚 The **3-Tier Architecture** is a software design pattern that organizes applications into three logical and physical tiers: **Presentation Layer**, **Business Logic Layer (BLL)**, and **Data Access Layer (DAL)**. This pattern promotes separation of concerns, making applications more scalable, maintainable, and testable.

---

## Why Use 3-Tier Architecture?

🎯 **Key Benefits:**

* 🔄 **Separation of Concerns**: Each layer has a specific responsibility.
* 🛠 **Maintainability**: Easier to update or fix individual layers.
* ♻️ **Reusability**: Logic and data access can be reused across multiple applications.
* 🚀 **Scalability**: You can scale each tier independently.

---

## 1. Presentation Layer (UI) 🎨

This is the front-end of the application that interacts with the user.

### Responsibilities:

* Displays data to users
* Sends user input to the BLL

### Example Technologies:

* ASP.NET Web Forms / MVC / Razor Pages

```csharp
// HomeController.cs
public class HomeController : Controller
{
    private readonly ProductService _productService = new ProductService();

    public IActionResult Index()
    {
        var products = _productService.GetAllProducts();
        return View(products);
    }
}
```

---

## 2. Business Logic Layer (BLL) 🧠

This layer contains the core business logic and rules.

### Responsibilities:

* Processes input from UI
* Calls DAL to retrieve/store data
* Applies business rules and validations

### Example:

```csharp
public class ProductService
{
    private readonly ProductRepository _repo = new ProductRepository();

    public List<Product> GetAllProducts()
    {
        return _repo.GetProducts();
    }
}
```

---

## 3. Data Access Layer (DAL) 🗄️

This layer handles interaction with the database.

### Responsibilities:

* Connects to the database
* Performs CRUD operations

### Example:

```csharp
public class ProductRepository
{
    public List<Product> GetProducts()
    {
        using (var context = new AppDbContext())
        {
            return context.Products.ToList();
        }
    }
}
```

---

## Folder Structure 🗂️

```
/YourProject
|-- /Controllers (Presentation Layer)
|-- /Services (Business Logic Layer)
|-- /Repositories (Data Access Layer)
|-- /Models
|-- /Views
|-- AppDbContext.cs
```

---

## Benefits in ASP.NET Projects ✅

* Encourages **clean architecture**.
* Easy to implement **unit testing**.
* **Decouples UI from data logic**, improving collaboration between front-end and back-end developers.

---

## Diagram Summary 🧭

```
[User Interface]
       |
       v
[ Business Logic Layer ]
       |
       v
[   Data Access Layer  ]
       |
       v
[     Database         ]
```

---

## Conclusion 🎓

Using the 3-Tier Architecture in ASP.NET projects allows for better code organization and application scalability. Whether you're building a small app or a large enterprise solution, following this pattern will keep your project clean and professional.

---

## Author ✍️

Created with ❤️ by Safiya Al Musharrafi
