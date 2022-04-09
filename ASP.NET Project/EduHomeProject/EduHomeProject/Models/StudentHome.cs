using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class StudentHome:BaseEntity
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public string StudentName{ get; set; }

        public string StudentSign { get; set; }
    }
}
