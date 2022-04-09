using EduHomeProject.Data;
using EduHomeProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Setting> GetSettings()
        {
            Setting settings = await _context.Setting.FirstOrDefaultAsync();
            return settings;
        }
        public async Task<List<Social>>GetSocial()
        {
            List<Social> socials = await _context.Social.ToListAsync();
            return socials;
        }
    }
}
