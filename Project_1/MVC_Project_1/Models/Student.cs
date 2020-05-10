using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class Student
    {
        [Key]
        public double Id { get; set; }
        [Display(Name = "Student Id")]
        [Required]
        public string StudentId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Acquired Credits")]
        public int AcquiredCredits { get; set; }
        [Display(Name = "Current Semester")]
        public int CurrentSemester { get; set; }
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }
        public ICollection<Enrollment> Courses { get; set; }
        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }

    }
}
