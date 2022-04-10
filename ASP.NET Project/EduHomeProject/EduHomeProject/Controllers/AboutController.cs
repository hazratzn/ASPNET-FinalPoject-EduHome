using EduHomeProject.Data;
using EduHomeProject.Models;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        

        public AboutController(AppDbContext context)
        {
            _context = context;
            
        }
        public async Task<IActionResult> Index()
        {
            HomeAbout homeabout = await _context.HomeAbout.FirstOrDefaultAsync();
            AboutTitle abouttitle = await _context.AboutTitle.FirstOrDefaultAsync();
            List<TeacherAbout> teacherabout = await _context.TeacherAbout.ToListAsync();
            StudentHome studenthome = await _context.StudentHome.FirstOrDefaultAsync();
            Video video = await _context.Video.FirstOrDefaultAsync();
            List<NoticeBoard> noticeboard = await _context.NoticeBoard.ToListAsync();
          





            AboutVM aboutVM = new AboutVM()
            {
                HomeAbout = homeabout,
                AboutTitle = abouttitle,
                TeacherAbout = teacherabout,
                StudentHome = studenthome,
                Video=video,
                NoticeBoards=noticeboard,
              
                
                
            };
            return View(aboutVM);
        }
    }
}
