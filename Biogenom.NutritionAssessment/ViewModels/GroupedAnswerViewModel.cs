namespace Biogenom.NutritionAssessment.ViewModels;

public class GroupedAnswerViewModel
{
    public int StepNumber { get; set; }
    public string StepTitle { get; set; } = string.Empty;
    public List<AnswerItemViewModel> Answers { get; set; } =  new List<AnswerItemViewModel>();
}