using System.ComponentModel.DataAnnotations;

namespace Biogenom.NutritionAssessment.Models
{
    public class Answer
    {
        public Guid Id { get; set; }

        public Guid AssessmentResultId { get; set; }
        public required AssessmentResult AssessmentResult { get; set; } = null!;

        public int QuestionId { get; set; }
        public required Question Question { get; set; } = null!;

        public int Frequency { get; set; }
        [MaxLength(15)]
        public required string Unit { get; set; }
    }
}