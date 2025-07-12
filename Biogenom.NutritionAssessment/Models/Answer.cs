using System;
using System.ComponentModel.DataAnnotations;

namespace Biogenom.NutritionAssessment.Models
{
    public class Answer
    {
        public Guid Id { get; set; }

        public Guid AssessmentResultId { get; set; }
        public AssessmentResult AssessmentResult { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int Frequency { get; set; }
        public string Unit { get; set; }
    }
}