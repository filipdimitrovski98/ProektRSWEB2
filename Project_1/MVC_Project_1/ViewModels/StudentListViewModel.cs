using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_1.Models;

namespace Project_1.ViewModels
{
    public class StudentListViewModel
    {
        public Student Student { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
    }
}
