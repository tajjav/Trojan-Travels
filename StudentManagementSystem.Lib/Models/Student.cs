using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Lib.Models
{
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? FirstName { get; set; }

        [MaxLength(10)]
        public string? Initials { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }
        public Gender? Gender { get; set; }

        [MaxLength(500)]
        public string? ImageFile { get; set; }
        public DateTime? EnrollmentDate { get; set; }

        public IList<Enrollment>? Enrollments { get; set; }

        [NotMapped]
        public string? SearchFirstName { get; set; }
        [NotMapped]
        public string? SearchLastName { get; set; }
        [NotMapped]
        public string? SearchGender { get; set; }
    }
}
