
using EduHomeProject.Data;
using EduHomeProject.Models;
using EduHomeProject.Services;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        private readonly LayoutService _layoutService;

        public HomeController(AppDbContext context, LayoutService layoutservice)
        {
            _context = context;
            _layoutService = layoutservice;
        }
       

        public async Task <IActionResult> Index()
        {
            List<Slider> sliders = await _context.Slider.ToListAsync();
            List<ProTeacher> proteachers = await _context.ProTeacher.ToListAsync();
            HomeAbout homeabout = await _context.HomeAbout.FirstOrDefaultAsync();
            CourseOffer courseoffer = await _context.CourseOffer.FirstOrDefaultAsync();
            List<HomeCourses> homecourses = await _context.HomeCourses.ToListAsync();
            Video video = await _context.Video.FirstOrDefaultAsync();
            List<NoticeBoard> noticeboards = await _context.NoticeBoard.ToListAsync();
            List<HomeEventUp> homeeventsup = await _context.HomeEventsUp.ToListAsync();
            List<HomeEventDown> homeeventsdown = await _context.HomeEventsDown.ToListAsync();
            StudentHome studenthome = await _context.StudentHome.FirstOrDefaultAsync();
            List<HomeBlog> homeblog = await _context.HomeBlog.ToListAsync();
            Setting settings = await _layoutService.GetSettings();





            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                ProTeachers = proteachers,
                HomeAbout = homeabout,
                CourseOffer = courseoffer,
                HomeCourses = homecourses,
                Video = video,
                NoticeBoards = noticeboards,
                HomeEventsUp = homeeventsup,
                HomeEventsDown = homeeventsdown,
                StudentHome = studenthome,
                HomeBlog = homeblog,
               
                
            };

            return View(homeVM);
        }

       
    }
}
