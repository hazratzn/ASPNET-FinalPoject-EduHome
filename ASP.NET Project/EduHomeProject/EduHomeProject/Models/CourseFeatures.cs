using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class CourseFeatures:BaseEntity
    {
        public string Starts { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string Students { get; set; }
        public string Language { get; set; }
        public string Assesments { get; set; }
        public int Price { get; set; }
    }
}
