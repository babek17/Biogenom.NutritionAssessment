using System.ComponentModel.DataAnnotations;

namespace Biogenom.NutritionAssessment.Models
{
    public class Question
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public required string Text { get; set; }

        public int StepId { get; set; }
        public required Step Step { get; set; } = null!;
    }
}