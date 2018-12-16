namespace LabSystem.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int EstimatedTime { get; set; }
        public int AttempsNumber { get; set; }
    }
}