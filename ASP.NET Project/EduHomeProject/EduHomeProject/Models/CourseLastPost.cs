﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class CourseLastPost:BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string From { get; set; }
        public string Date { get; set; }
    }
}
