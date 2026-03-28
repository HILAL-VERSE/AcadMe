namespace AcadMe.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Grade { get; set; } = string.Empty;
        public double GradePoint { get; set; }
        public Subject Subject { get; set; } = null!;
    }
}