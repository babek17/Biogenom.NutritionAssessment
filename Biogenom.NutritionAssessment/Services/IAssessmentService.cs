using System.Collections.Generic;
using System.Threading.Tasks;
using Biogenom.NutritionAssessment.ViewModels;

namespace Biogenom.NutritionAssessment.Services
{
    public interface IAssessmentService
    {
        Task<List<GroupedAnswerViewModel>> GetGroupedAnswersAsync();
    }
}