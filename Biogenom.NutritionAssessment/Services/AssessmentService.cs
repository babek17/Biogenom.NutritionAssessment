using Microsoft.EntityFrameworkCore;
using Biogenom.NutritionAssessment.Data;
using Biogenom.NutritionAssessment.ViewModels;

namespace Biogenom.NutritionAssessment.Services
{
    public class AssessmentService : IAssessmentService
    {
        private readonly AppDbContext _context;

        public AssessmentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GroupedAnswerViewModel>> GetGroupedAnswersAsync()
        {
            var result = await _context.AssessmentResults
                .Include(r => r.Answers)
                .ThenInclude(a => a.Question)
                .ThenInclude(q => q.Step)
                .OrderByDescending(r => r.CreatedAt)
                .FirstOrDefaultAsync();

            if (result == null)
                return new List<GroupedAnswerViewModel>();

            var grouped = result.Answers
                .GroupBy(a => a.Question.Step)
                .OrderBy(g => g.Key.StepNumber)
                .Select(g => new GroupedAnswerViewModel()
                {
                    StepNumber = g.Key.StepNumber,
                    StepTitle = g.Key.Title,
                    Answers = g.Select(a => new AnswerItemViewModel()
                    {
                        Question = a.Question.Text,
                        Frequency = a.Frequency,
                        Unit = a.Unit
                    }).ToList()
                })
                .ToList();

            return grouped;
        }
    }
}