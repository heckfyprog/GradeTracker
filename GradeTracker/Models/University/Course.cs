using System.ComponentModel.DataAnnotations;

namespace GradeTracker.Models.University
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int SemesterId { get; set; }
        public Semester? Semester { get; set; }
    
        public List<float> Grades { get; set; } = new List<float>();

        public List<string> Assignments { get; set; } = new List<string>();


    }
}
