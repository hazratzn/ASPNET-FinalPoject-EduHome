﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class HomeAbout:BaseEntity
    {
        public string Ttile { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
