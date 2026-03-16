namespace AcadMe.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public int SemesterId { get; set; }
        public string CourseCode { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Credits { get; set; }
        public bool HasPractical { get; set; }
        public bool IsAudit {  get; set; }
        public bool IsActive { get; set; } = true;
        public Semester Semester { get; set; } = null!;
        public List<AttendanceLog> AttendanceLogs { get; set; } = new List<AttendanceLog>();
    }
}
