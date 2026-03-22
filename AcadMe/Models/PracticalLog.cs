namespace AcadMe.Models
{
    public class PracticalLog
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsDone { get; set; }
        public string Notes { get; set; } = string.Empty;
        public DateTime? CompletedOn { get; set; }

        public Subject Subject { get; set; } = null!;
    }
}
