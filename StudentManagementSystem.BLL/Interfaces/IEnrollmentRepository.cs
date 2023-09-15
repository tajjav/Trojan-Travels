using StudentManagementSystem.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentManagementSystem.BLL.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<IList<Enrollment>> GetAllEnrollments();
        Task<Enrollment> GetEnrollment(int id);
        Task<Enrollment> AddEnrollment(Enrollment newEnrollment);
        Task<Enrollment> UpdateEnrollment(Enrollment updatedEnrollment);
        Task<IList<CourseEnrollmentCount>> CourseEnrollmentCount(string title);

        Task<Enrollment> DeleteEnrollment(int id);
    }
}
