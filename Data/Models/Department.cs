namespace eMungesat.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Nav
        public ICollection<AcademicYear> AcademicYears { get; set; }
    }
}
