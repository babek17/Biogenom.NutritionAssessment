using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biogenom.NutritionAssessment.Data;
using Biogenom.NutritionAssessment.Services;

namespace Biogenom.NutritionAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssessmentController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAssessmentService  _assessmentService;

        public AssessmentController(AppDbContext context, IAssessmentService assessmentService)
        {
            _context = context;
            _assessmentService = assessmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetLatestAssessment()
        {
            var result = await _context.AssessmentResults
                .OrderByDescending(r => r.CreatedAt)
                .Select(r => new
                {
                    r.Id,
                    r.CreatedAt,
                    r.TotalScore,
                    r.DeficiencySummary,
                    r.Recommendation
                })
                .FirstOrDefaultAsync();

            if (result == null)
                return NotFound("No assessment results found.");

            return Ok(result);
        }

        [HttpGet("answers")]
        public async Task<IActionResult> GetLatestAssessmentAnswers()
        {
            var groupedAnswers = await _assessmentService.GetGroupedAnswersAsync();

            return Ok(groupedAnswers);
        }
    }
}
