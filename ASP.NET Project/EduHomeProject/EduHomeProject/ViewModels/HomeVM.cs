using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<ProTeacher> ProTeachers { get; set; }

        public HomeAbout HomeAbout { get; set; }
        public CourseOffer CourseOffer { get; set; }
        public List<HomeCourses> HomeCourses { get; set; }
        public Video Video { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<HomeEventUp> HomeEventsUp { get; set; }
        public List<HomeEventDown> HomeEventsDown { get; set; }
        public StudentHome StudentHome { get; set; }
        public List<HomeBlog> HomeBlog { get; set; }
        public Setting Setting { get; set; }


    }
}
