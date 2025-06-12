# APBD – 2nd Test (EF Core) Hints

## ✅ Project Structure

Your project **must exactly follow** this folder and class structure:

```
- Data
  - AppDbContext.cs
- Controllers
  - TestsController.cs
- Services
  - ITestsService.cs      (Interface)
  - TestsService.cs       (Implementation)
- Models
  - Entities
    - Test.cs
  - DTOs
    - TestDto.cs
```

> ⚠️ Deviating from this structure may result in your project not being graded correctly.

---

## 🧩 Key Requirements

- **EF Core** must be used for all database operations.
- **Only read operations** can be non-transactional; all others **must be wrapped in a transaction**.
- **No anonymous objects** can be returned from services. Always return strongly typed objects (like DTOs).
- Apply proper separation of concerns between:
  - Controllers (expose endpoints)
  - Services (business logic)
  - Data (DB context)
  - Models (entities and DTOs)

---

## 📦 Required NuGet Packages

Make sure to install the following packages via NuGet Package Manager or using the .NET CLI:

### 1. Entity Framework Core
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 2. Swagger (for API documentation)
```bash
dotnet add package Swashbuckle.AspNetCore
```

### 3. Migrations (included with EF Core Tools)
EF Core Tools are required for adding migrations and updating the database.

> Already covered by:  
> `Microsoft.EntityFrameworkCore.Tools`

---

## 💡 Usage Examples

### Add Migration
```bash
dotnet ef migrations add InitialCreate
```

### Update Database
```bash
dotnet ef database update
```

### Run Application
```bash
dotnet run
```

---

## 📝 Good Practices

- Define and register your services in `Program.cs` or `Startup.cs`:
  ```csharp
  builder.Services.AddScoped<ITestsService, TestsService>();
  ```

- Use `[ApiController]` and `[Route("api/[controller]")]` on `TestsController`.

- Avoid business logic in the controller — delegate to `TestsService`.
