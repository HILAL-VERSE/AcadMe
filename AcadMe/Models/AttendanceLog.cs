namespace AcadMe.Models
{
    public class AttendanceLog
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;

        public Subject Subject { get; set; } = null!;
    }
}
