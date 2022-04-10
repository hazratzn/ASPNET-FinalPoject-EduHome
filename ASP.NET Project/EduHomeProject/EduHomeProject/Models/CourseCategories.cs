using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class CourseCategories:BaseEntity
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
