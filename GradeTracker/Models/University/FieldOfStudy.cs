using System.ComponentModel.DataAnnotations;

namespace GradeTracker.Models.University
{
    internal class FieldOfStudy
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<AcademicYear> AcademicYears { get; set; } = new List<AcademicYear>();
        public List<Semester> Semesters { get; set; } = new List<Semester>();

    }
}
