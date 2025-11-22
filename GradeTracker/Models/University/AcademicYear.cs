

using System.ComponentModel.DataAnnotations;

namespace GradeTracker.Models.University
{
    internal class AcademicYear
    {
        [Key]
        public int Id { get; set; }

        public int YearNumber { get; set; }

        public int FieldOfStudyId { get; set; }
        public FieldOfStudy? FieldOfStudy { get; set; }

        public List<Semester> Semesters { get; set; } = new List<Semester>();

    }
}
