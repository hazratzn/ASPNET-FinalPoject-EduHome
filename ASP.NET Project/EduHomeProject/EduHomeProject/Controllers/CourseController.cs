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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;


        public CourseController(AppDbContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            List<Courses> courses = await _context.Courses.ToListAsync();
            CourseTitle coursetitle = await _context.CourseTitle.FirstOrDefaultAsync();





            CoursesVM courseVM = new CoursesVM()
            {
             Courses = courses,
             CourseTitle = coursetitle,


            };

            return View(courseVM);
        }

        public async Task<IActionResult> CourseDetails()
        {
            
            CourseDetailsBody coursedetailsbody = await _context.CourseDetailsBody.FirstOrDefaultAsync();
            CourseFeatures coursefeatures = await _context.CourseFeatures.FirstOrDefaultAsync();
            List<CourseCategories> coursecategories = await _context.CourseCategories.ToListAsync();
            CourseTheme coursetheme = await _context.CourseThemes.FirstOrDefaultAsync();
            List<CourseLastPost> courselastpost = await _context.CourseLastPost.ToListAsync();
            List<CourseTags> coursetags = await _context.CourseTags.ToListAsync();
            CourseDetailsHeader coursedetailsheader = await _context.CourseDetailsHeader.FirstOrDefaultAsync();





            CourseDetailsVM coursedetailsVM = new CourseDetailsVM()
            {
               
                CourseDetailsBody = coursedetailsbody,
                CourseFeatures = coursefeatures,
                CourseCategories = coursecategories,
                CourseTheme = coursetheme,
                CourseLastPost = courselastpost,
                CourseTags = coursetags,
                CourseDetailsHeader = coursedetailsheader,

            };

            return View(coursedetailsVM);
        }



    }

}

