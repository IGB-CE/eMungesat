namespace eMungesat.Data.Models
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //FK
        public int AcademicYearId { get; set; }
        //Nav
        public AcademicYear AcademicYear { get; set; }
        public ICollection<ApplicationUser> Students { get; set; }

        public ICollection<CourseGroup> CourseGroups { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
