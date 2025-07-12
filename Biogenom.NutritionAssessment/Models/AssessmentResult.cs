using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biogenom.NutritionAssessment.Models
{
    public class AssessmentResult
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string DeficiencySummary { get; set; }

        public string Recommendation { get; set; }

        public int TotalScore { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}