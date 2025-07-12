using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biogenom.NutritionAssessment.Models
{
    public class Step
    {
        public int Id { get; set; }

        public int StepNumber { get; set; }
        [MaxLength(100)]
        public required string Title { get; set; }

        public ICollection<Question> Questions { get; set; } =  new List<Question>();
    }
}