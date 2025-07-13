# 🍽️ Biogenom Nutrition Assessment API

This is a backend Web API project built as a test assignment for **ООО Биогеном**.  
It simulates the server-side functionality behind the **“Оценка качества питания (краткая)”** screen in the [Biogenom mobile app](https://biogenom.ru/mob-app), which provides users with personalized nutrition quality feedback after completing a questionnaire.

---

## 🧠 Task Summary

The API:
- Returns the **latest nutrition assessment result** for a single user.
- Assumes the data is already stored in a normalized PostgreSQL database.
- Does not require user authentication or handling multiple users.
- Implements a **non-Minimal ASP.NET Core Web API** structure using EF Core.

---

## ⚙️ Tech Stack

- ASP.NET Core Web API (no top-level statements)
- Entity Framework Core
- PostgreSQL (Dockerized)
- Layered architecture (Controller → Service → Repository)

---

## 📁 Project Structure

```text
├── Controllers/
│   └── NutritionController.cs
├── Services/
│   └── INutritionService.cs
│   └── NutritionService.cs
├── Repositories/
│   └── INutritionRepository.cs
│   └── NutritionRepository.cs
├── Models/
│   └── NutritionResult.cs
│   └── NutritionCategory.cs
│   └── NutritionRecommendation.cs
├── Data/
│   └── AppDbContext.cs
├── docs/
│   └── diagram.png (database schema)
├── README.md
