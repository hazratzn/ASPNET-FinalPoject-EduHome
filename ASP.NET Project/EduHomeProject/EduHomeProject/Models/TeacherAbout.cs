﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class TeacherAbout:BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Profession { get; set; }
    }
}
