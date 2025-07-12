using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biogenom.NutritionAssessment.Models
{
    public class Step
    {
        public int Id { get; set; }

        [Required]
        public int StepNumber { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}