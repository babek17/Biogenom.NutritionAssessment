using Biogenom.NutritionAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Biogenom.NutritionAssessment.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Step> Steps { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AssessmentResult> AssessmentResults { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public void SeedDevData()
        {
            if (!AssessmentResults.Any())
            {
                var step = new Step { StepNumber = 1, Title = "Fruits and Vegetables" };
                Steps.Add(step);

                var question1 = new Question { Text = "How often do you eat apples?", Step = step };
                var question2 = new Question { Text = "How often do you eat spinach?", Step = step };
                Questions.AddRange(question1, question2);

                var result = new AssessmentResult
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    DeficiencySummary = "Low in Iron and Vitamin D",
                    Recommendation = "Eat more leafy greens and fish.",
                    TotalScore = 65
                };
                AssessmentResults.Add(result);

                Answers.AddRange(new Answer
                {
                    Id = Guid.NewGuid(),
                    AssessmentResult = result,
                    Question = question1,
                    Frequency = 3,
                    Unit = "week"
                },
                new Answer
                {
                    Id = Guid.NewGuid(),
                    AssessmentResult = result,
                    Question = question2,
                    Frequency = 1,
                    Unit = "week"
                });

                SaveChanges();
            }
        }
    }
}
