using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class CoursesVM
    {
        public List<Courses> Courses { get; set; }
        public CourseTitle CourseTitle { get; set; }
    }
}
