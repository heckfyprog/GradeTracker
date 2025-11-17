using System.ComponentModel.DataAnnotations;


namespace GradeTracker.Models.University
{
    internal class Semester
    {
        [Key]
        public int Id { get; set; }
    
        public int SemesterNumber { get; set; }

        public int AcademicYearId { get; set; }
        public AcademicYear? AcademicYear { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();

    }
}
