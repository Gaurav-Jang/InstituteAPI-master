using InstituteAPI.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer.Interface
{
    public interface IStudentRepository
    {
        void DeleteStudent(int studentId);
        public List<Student> GetActiveStudent();
        public int SetStudent(Student student);
        public int CheckDuplicateStudent(Student student);
        public Student GetStudentByStudentId(int Student);
        public int UpdateStudent(Student student);

    }
}

