using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Lib.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Title { get; set; }
        public int Credits { get; set; }

        [MaxLength(200)]
        public string? Instructor { get; set; }

        public IList<Enrollment> Enrollments { get; set; }
    }
}
