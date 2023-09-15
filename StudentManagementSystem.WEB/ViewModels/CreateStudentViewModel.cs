using StudentManagementSystem.Lib.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.WEB.ViewModels
{
    public class CreateStudentViewModel
    {
        [Required(ErrorMessage = "First name required")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        public string? Initials { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please select a gender")]
        public Gender? Gender { get; set; }

        public IFormFile? Photo { get; set; }

        [Required(ErrorMessage = "Enrollment date required")]
        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public IList<Enrollment>? Enrollments { get; set; }
    }
}
