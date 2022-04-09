using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class HomeBlog:BaseEntity
    {
        public string Image { get; set; }
        public string  FromWho { get; set; }
        public string Date { get; set; }
        public string Comments { get; set; }
        public string Title { get; set; }
    }
}
