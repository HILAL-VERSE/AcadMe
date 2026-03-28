using AcadMe.Models;
using Microsoft.EntityFrameworkCore;

namespace AcadMe.Data
{
    public class AcadMeDbContext : DbContext
    {
        public DbSet<AttendanceLog> AttendanceLogs { get; set; }
        public DbSet<PersonalTask> PersonalTasks { get; set; }
        public DbSet<PracticalLog> PracticalLogs { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source = acadme.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}