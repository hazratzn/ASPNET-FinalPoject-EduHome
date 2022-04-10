using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class AboutVM
    {
        public HomeAbout HomeAbout { get; set; }
        public AboutTitle AboutTitle { get; set; }
        public List<TeacherAbout> TeacherAbout { get; set; }
        public StudentHome StudentHome { get; set; }
        public Video Video { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
     
    }
}
