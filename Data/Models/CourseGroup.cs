using Microsoft.EntityFrameworkCore;

namespace eMungesat.Data.Models
{
    
    public class CourseGroup
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentGroupId { get; set; }
        public StudentGroup StudentGroup { get; set; }
    }
}
