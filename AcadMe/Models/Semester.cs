namespace AcadMe.Models
{
    public class Semester
    {
        public int Id { get; set; }
        public int SemNo { get; set; }
        public string AcademicYear { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public bool ResultsIn { get; set; }

        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
