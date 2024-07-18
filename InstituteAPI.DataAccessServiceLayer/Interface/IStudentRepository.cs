using InstituteAPI.Models.Student;

namespace InstituteAPI.DataAccessServiceLayer.Interface
{
    public interface IStudentRepository
    {
        void DeleteStudent(int studentId);
        public List<Student> GetActiveStudent();
        public int SetStudent(Student student);
        public int CheckDuplicateStudent(Student student);
        public Student GetStudentByStudentId(int studentId);
        int UpdateStudent(Student student);
    }
}

