namespace LabSystem.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int WorkTime { get; set; }
        public int OrderId { get; set; }
        public int Distance { get; set; }
        public int OperationCosts { get; set; }
        public double Profit { get; set; }

    }
}