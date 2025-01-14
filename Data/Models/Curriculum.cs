namespace eMungesat.Data.Models
{
    public class Curriculum
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //FK
        public int AcademicYearId { get; set; }
        //Nav
        public AcademicYear AcademicYear { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
