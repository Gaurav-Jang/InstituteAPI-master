using InstituteAPI.BusinessServiceLayer.Services;
using InstituteAPI.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.BusinessServiceLayer.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetActiveStudent();
        public int SetStudent(Student student);
        public void DeleteStudent(int studentId);
    }
}

