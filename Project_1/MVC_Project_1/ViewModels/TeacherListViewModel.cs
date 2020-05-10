using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_1.Models;

namespace Project_1.ViewModels
{
    public class TeacherListViewModel
    {
        public Teacher Teacher { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
