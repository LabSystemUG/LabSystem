namespace LabSystem.Models
{
    public class Sample
    {
        public int SampleId { get; set; }
        public int SurveyId { get; set; }
        // TODO: zmienić na ENUM
        public int State { get; set; }
        public string Description { get; set; }
    }
}