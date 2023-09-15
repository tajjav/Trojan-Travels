using EnrollmentManagementSystem.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.BLL.Interfaces;
using StudentManagementSystem.Lib.Models;
using StudentManagementSystem.WEB.ViewModels;

namespace StudentManagementSystem.WEB.Controllers
{
    public class EnrollmentsController : Controller
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public EnrollmentsController(IEnrollmentRepository enrollmentRepository,
            IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _enrollmentRepository = enrollmentRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        // GET: EnrollmentsController
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            IList<Enrollment> enrollments = await _enrollmentRepository.GetAllEnrollments();
            return View(enrollments);
        }

        // GET: EnrollmentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnrollmentsController/Details/5
        [HttpGet]
        public async Task<ActionResult> AddGrade(int id)
        {
            Enrollment enrollment = await _enrollmentRepository.GetEnrollment(id);

            AddGradeViewModel addGradeVM = new AddGradeViewModel()
            {
                Id = enrollment.Id,
                CourseID = enrollment.CourseID,
                StudentID = enrollment.StudentID,
                CourseTitle = enrollment.Course.Title,
                StudentName = $"{enrollment.Student.FirstName} {enrollment.Student.LastName}",
                Grade = enrollment.Grade
            };

            return View(addGradeVM);
        }

        [HttpPost]
        public async Task<ActionResult> AddGrade(AddGradeViewModel addGradeVM)
        {
            Enrollment enrollment = new Enrollment()
            {
                Id = addGradeVM.Id,
                CourseID = addGradeVM.CourseID,
                StudentID = addGradeVM.StudentID,
                Grade = addGradeVM.Grade
            };

            await _enrollmentRepository.UpdateEnrollment(enrollment);

            return RedirectToAction("Index", "Enrollments");
        }

        // GET: EnrollmentsController/Create
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            ViewData["Students"] = (await _studentRepository.GetAllStudents())
                .Select( s =>
                new SelectListItem { Text = $"{s.FirstName} {s.LastName}", Value = s.Id.ToString()});

            ViewData["Courses"] = (await _courseRepository.GetAllCourses())
                .Select(c => new SelectListItem { Text = c.Title, Value = c.Id.ToString()});

            return View();
        }

        // POST: EnrollmentsController/Create
        
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateEnrollmentViewModel createEnrollmentVM)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                Enrollment enrollment = new Enrollment() 
                {
                    CourseID = createEnrollmentVM.CourseID.Value,
                    StudentID = createEnrollmentVM.StudentID.Value,
                    Grade = createEnrollmentVM.Grade
                };
                await _enrollmentRepository.AddEnrollment(enrollment);

                return RedirectToAction("Index", "Enrollments");
            }
            catch
            {
                return View();
            }
        }

        // GET: EnrollmentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnrollmentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EnrollmentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnrollmentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
