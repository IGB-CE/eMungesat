namespace eMungesat.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //FK
        public int CurriculumId { get; set; }
        //Nav
        public Curriculum Curriculum { get; set; }
        public ICollection<CourseGroup> CourseGroups { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
