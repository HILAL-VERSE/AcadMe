using AcadMe.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using AcadMe.Data;
using Microsoft.EntityFrameworkCore;

namespace AcadMe.ViewModels
{
    public class SubjectsViewModel : BaseViewModel
    {
        private readonly AcadMeDbContext _dbContext;
        private ObservableCollection<Subject> _subjects = new();
        public ObservableCollection<Subject> Subjects
        {
            get { return _subjects; }
            set {
                _subjects = value;
                OnPropertyChanged();
                }
        }
        public SubjectsViewModel()
        {
            _dbContext = new AcadMeDbContext();
            _dbContext.Database.Migrate();
            SeedInitialData();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            var subjects = _dbContext.Subjects
                .Where(s => s.IsActive == true)
                .ToList();
            Subjects = new ObservableCollection<Subject>(subjects);
        }

        private void SeedInitialData()
        {
            if (!_dbContext.Semesters.Any())
            {
                var semester2 = new Semester
                {
                    SemNo = 2,
                    AcademicYear = "2025",
                    Status = "Active",
                    ResultsIn = false
                };
                _dbContext.Semesters.Add(semester2);
                _dbContext.SaveChanges();

                var subjects = new List<Subject>
                {
                    new Subject
                    {
                        SemesterId = semester2.Id,
                        CourseCode = "MAD201",
                        Title = "Programming with Python",
                        Type = "Theory",
                        Credits = 4,
                        HasPractical = true,
                        IsAudit = false,
                        IsActive = true
                    },
                    new Subject
                    {
                        SemesterId = semester2.Id,
                        CourseCode = "MAD202",
                        Title = "ADBMS",
                        Type = "Theory",
                        Credits = 3,
                        HasPractical = true,
                        IsAudit = false,
                        IsActive = true
                    }
                };

                _dbContext.Subjects.AddRange(subjects);
                _dbContext.SaveChanges();
            }
        }
    }
}
