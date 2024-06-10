using System.Diagnostics;
using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace InstituteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;
        private readonly IStudentService _studentService;
        public StudentController(ILogger<StudentController> logger, IStudentService StudentService)
        {
            _logger = logger;
            _studentService = StudentService;
        }
        //Get
        [HttpGet()]
        [Route("GetActiveStudent")]
        public IActionResult GetActiveStudent()
        {
            List<Student> students = _studentService.GetActiveStudent();
            return Ok(students);
        }
        // Get Delete Student
        [HttpGet]
        [Route("DeleteStudent")]
        public IActionResult DeleteStudent(int studentId)
        {
            _studentService.DeleteStudent(studentId);
            return Ok();
        }

        ///Post
        [HttpPost]
        [Route("SetStudent")]
        public IActionResult SetStudent([FromBody] Student student)
        {

            int StudentId = _studentService.SetStudent(student);
            return Ok(StudentId);
        }
    }
}
