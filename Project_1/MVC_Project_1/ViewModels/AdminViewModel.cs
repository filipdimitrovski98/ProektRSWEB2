using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project_1.ViewModels
{
    public class AdminViewModel
    {
        public IList<Course> Courses { get; set; }
        public IList<Teacher> Teachers { get; set; }
        public IList<Student> Students { get; set; }
    }
}
