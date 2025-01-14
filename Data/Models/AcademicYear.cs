namespace eMungesat.Data.Models
{
    public class AcademicYear
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        //Foreign Key
        public int DepartmentId { get; set; }

        //Nav
        public Department Department { get; set; }
        public ICollection<Curriculum> Curricula { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();
    }
}
