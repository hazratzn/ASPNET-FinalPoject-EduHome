using EduHomeProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<ProTeacher> ProTeacher { get; set; }

        public DbSet<HomeAbout> HomeAbout{ get; set; }
        public DbSet<CourseOffer> CourseOffer { get; set; }
        public DbSet<HomeCourses> HomeCourses{ get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<NoticeBoard> NoticeBoard { get; set; }
        public DbSet<HomeEventUp> HomeEventsUp { get; set; }
        public DbSet<HomeEventDown> HomeEventsDown { get; set; }
        public DbSet<StudentHome> StudentHome{ get; set; }
        public DbSet<HomeBlog> HomeBlog { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Social> Social { get; set; }
    }
}
