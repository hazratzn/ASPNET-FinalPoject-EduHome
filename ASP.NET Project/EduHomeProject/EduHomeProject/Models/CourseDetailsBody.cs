using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class CourseDetailsBody:BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  string About { get; set; }
        public string  Apply { get; set; }
        public string Certificate { get; set; }
    }
}
