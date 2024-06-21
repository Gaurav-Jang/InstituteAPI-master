using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.DataAccessServiceLayer.Repository;
using InstituteAPI.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.BusinessServiceLayer.Services
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository userRepo)
        {
            _studentRepository = userRepo;
        }
        public List<Student> GetActiveStudent()
        {
            return _studentRepository.GetActiveStudent();
        }

        public int SetStudent(Student student)
        {
            return _studentRepository.SetStudent(student);
        }

        public void DeleteStudent(int studentId)
        {
            _studentRepository.DeleteStudent(studentId);
        }
    }
}
