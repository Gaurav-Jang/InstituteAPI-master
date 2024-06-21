using Dapper;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.Student;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer.Repository
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(IConfiguration config) : base(config)
        {

        }

        public List<Student> GetActiveStudent()
        {
            List<Student> StudentDetails = new List<Student>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                var result = con.Query<Student>(Constants.StoreProcedures.GetActiveStudent, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    StudentDetails = result.ToList();
                }
            }
            return StudentDetails;
        }

        public int SetStudent(Student student)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inStudentId, student.StudentId);
                spParam.Add(Constants.Parameters.inStudentFirstName, student.StudentFirstName);
                spParam.Add(Constants.Parameters.inStudentLastName, student.StudentLastName);
                spParam.Add(Constants.Parameters.inMobileNumber, student.MobileNumber);
                spParam.Add(Constants.Parameters.inGender, student.Gender);
                spParam.Add(Constants.Parameters.inDob, student.Dob);
                spParam.Add(Constants.Parameters.inFatherFirstName, student.FatherFirstName);
                spParam.Add(Constants.Parameters.inFatherLastName, student.FatherLastName);
                spParam.Add(Constants.Parameters.inFatherMobileNumber, student.FatherMobileNumber);
                spParam.Add(Constants.Parameters.inMotherFirstName, student.MotherFirstName);
                spParam.Add(Constants.Parameters.inMotherLastName, student.MotherLastName);
                spParam.Add(Constants.Parameters.inMotherMobileNumber, student.MotherMobileNumber);
                spParam.Add(Constants.Parameters.inStudentClassRoomName, student.StudentClassRoomName);
                spParam.Add(Constants.Parameters.inAddress, student.Address);
                spParam.Add(Constants.Parameters.inCategory, student.Category);
                spParam.Add(Constants.Parameters.inRemarks, student.Remarks);
                /*spParam.Add(Constants.Parameters.inPhoto, student.Photo);*/
                spParam.Add(Constants.Parameters.inAvailingTransport, student.AvailingTransport);
                spParam.Add(Constants.Parameters.inAvailingSchool, student.AvailingSchool);
                spParam.Add(Constants.Parameters.inAvailingHostel, student.AvailingHostel);
                spParam.Add(Constants.Parameters.inMigrated, student.Migrated);
                spParam.Add(Constants.Parameters.inIsActive, student.IsActive);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.SetStudent, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);
            }

        }

        public void DeleteStudent(int studentId)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inStudentId, studentId);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query(Constants.StoreProcedures.DeleteStudent, dynParam, commandType: CommandType.StoredProcedure);
            }

        }
    }
}

