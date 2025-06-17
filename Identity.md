
# 🔐 ASP.NET Identity

**ASP.NET Identity** is the membership system used in ASP.NET applications to manage **authentication**, **authorization**, and **user management** in a secure and extensible way.

---

## 📌 What Is ASP.NET Identity?

ASP.NET Identity is a system that allows developers to:

- ✅ Authenticate users (login/register)
- ✅ Manage roles and claims (authorization)
- ✅ Store user information securely (passwords, emails, etc.)
- ✅ Integrate with external providers (Google, Facebook, Microsoft, etc.)
- ✅ Support token-based authentication (JWT for APIs)

It replaces older membership systems like `Membership`, `SimpleMembership`, and `Forms Authentication`.

---

## 🧱 Core Features

| 🛠️ Feature              | 📋 Description                                                  |
|-------------------------|------------------------------------------------------------------|
| 🔑 Authentication        | Handles user login, logout, and registration                    |
| 🔒 Authorization         | Role-based and claim-based access control                       |
| 🧑 User Profiles         | Stores email, username, password hash, and custom fields        |
| 🔄 External Logins       | Google, Facebook, Microsoft, Twitter integration                |
| 🧾 Claims                | Supports claims-based identity and policies                     |
| 🔧 Extensible            | Easily customizable to fit business needs                       |

---

## 🧩 Default Identity Structure

ASP.NET Identity provides default entities like:

- `IdentityUser`
- `IdentityRole`
- `IdentityDbContext`

You can extend these classes to add custom properties.

```csharp
public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
}
```

---

## ⚙️ How It Works (Overview)

1. **User Registers** → User is stored in the `AspNetUsers` table.
2. **User Logs In** → Credentials are verified and claims are generated.
3. **Authorization** → Roles and claims are checked to allow/deny access.

---

## 📦 Common Identity Tables

| Table Name         | Purpose                          |
|--------------------|----------------------------------|
| `AspNetUsers`      | Stores user info                 |
| `AspNetRoles`      | Stores roles like Admin, User    |
| `AspNetUserRoles`  | Maps users to roles              |
| `AspNetUserClaims` | Stores claims per user           |
| `AspNetLogins`     | For external login providers     |
| `AspNetTokens`     | For refresh tokens, etc.         |

---

## 🔐 Sample: Registering Identity in `Startup.cs` (ASP.NET Core)

```csharp
services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
```

---

## 🚪 Example: Role-Based Authorization

```csharp
[Authorize(Roles = "Admin")]
public IActionResult AdminPanel()
{
    return View();
}
```

---

## 🔄 External Logins (OAuth Providers)

ASP.NET Identity supports social logins:

```csharp
services.AddAuthentication()
    .AddGoogle(options => {
        options.ClientId = "your-client-id";
        options.ClientSecret = "your-client-secret";
    });
```

---

## 🧪 Identity with JWT (for APIs)

You can use Identity with JWT tokens for APIs:

```csharp
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            // ...other JWT validation configs
        };
    });
```

---

## ✅ Summary

ASP.NET Identity is a powerful system that gives you:

- 🛡️ Secure user authentication
- 👥 Role & claim-based access
- 🔌 Integration with external providers
- 🧩 Customization for any business model
