using EduHomeProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<ProTeacher> ProTeacher { get; set; }

        public DbSet<HomeAbout> HomeAbout { get; set; }
        public DbSet<CourseOffer> CourseOffer { get; set; }
        public DbSet<HomeCourses> HomeCourses { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<NoticeBoard> NoticeBoard { get; set; }
        public DbSet<HomeEventUp> HomeEventsUp { get; set; }
        public DbSet<HomeEventDown> HomeEventsDown { get; set; }
        public DbSet<StudentHome> StudentHome { get; set; }
        public DbSet<HomeBlog> HomeBlog { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Social> Social { get; set; }
        public DbSet<AboutTitle> AboutTitle { get; set; }
        public DbSet<TeacherAbout> TeacherAbout { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CourseTitle> CourseTitle { get; set; }
        public DbSet<CourseDetailsBody> CourseDetailsBody { get; set; }
        public DbSet<CourseFeatures> CourseFeatures { get; set; }

        public DbSet<CourseCategories> CourseCategories { get; set; }

        public DbSet<CourseTheme> CourseThemes { get; set; }
        public DbSet<CourseLastPost> CourseLastPost { get; set; }
        public DbSet<CourseTags> CourseTags { get; set; }

        public DbSet<CourseDetailsHeader> CourseDetailsHeader { get; set; }





    }
}
