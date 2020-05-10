using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_1.Models;

namespace Project_1.ViewModels
{
    public class EnrollMultipleViewModel
    {
        public SelectList CoursesList { get; set; }
        public IEnumerable<SelectListItem> StudentList { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }
        public IEnumerable<double> SelectedStudents { get; set; }
        public Course Course { get; set; }
        public Enrollment Enrollment { get; set; }
        public Student Student { get; set; }
    }
}
