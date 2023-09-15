﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Lib.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
