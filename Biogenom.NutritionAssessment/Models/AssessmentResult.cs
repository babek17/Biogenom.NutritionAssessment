using System.ComponentModel.DataAnnotations;

namespace Biogenom.NutritionAssessment.Models
{
    public class AssessmentResult
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [MaxLength(255)]
        public required string DeficiencySummary { get; set; }

        [MaxLength(500)]
        public required string Recommendation { get; set; }

        public int TotalScore { get; set; }

        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}