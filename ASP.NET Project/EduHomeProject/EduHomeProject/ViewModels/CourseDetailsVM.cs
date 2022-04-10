using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class CourseDetailsVM
    {
        public CourseDetailsBody CourseDetailsBody { get; set; }
        public CourseFeatures CourseFeatures { get; set; }
        public List<CourseCategories> CourseCategories { get; set; }
        public CourseTheme CourseTheme { get; set; }
        public List<CourseLastPost> CourseLastPost { get; set; }
        public List<CourseTags> CourseTags { get; set; }
        public CourseDetailsHeader CourseDetailsHeader { get; set; }
    }
}
