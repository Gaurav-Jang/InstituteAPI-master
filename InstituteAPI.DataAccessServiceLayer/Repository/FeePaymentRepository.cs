using Dapper;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.FeesPayment;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace InstituteAPI.DataAccessServiceLayer.Repository
{
    public class FeePaymentRepository : BaseRepository, IFeePaymentRepository
    {
        public FeePaymentRepository(IConfiguration config) : base(config)
        {

        }

        public List<FeePayment> GetActiveFeePayment()
        {
            List<FeePayment> feePaymentDetails = new List<FeePayment>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                var result = con.Query<FeePayment>(Constants.StoreProcedures.GetActiveFeesPayment, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    feePaymentDetails = result.ToList();
                }
            }
            return feePaymentDetails;
        }

        public int SetClassRoom(FeePayment feePayment)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inClassRoomName, classRoom.ClassRoomName);
                spParam.Add(Constants.Parameters.inClass, classRoom.Class);
                spParam.Add(Constants.Parameters.inClassRoomType, classRoom.ClassRoomType);
                spParam.Add(Constants.Parameters.inPrice, classRoom.Price);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.SetClassRoom, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);

            }

        }

        public int CheckDuplicateClassRoom(ClassRoom classRoom)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inClassRoomName, classRoom.ClassRoomName);
                spParam.Add(Constants.Parameters.inClass, classRoom.Class);
                spParam.Add(Constants.Parameters.inClassRoomType, classRoom.ClassRoomType);
                spParam.Add(Constants.Parameters.inPrice, classRoom.Price);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var CheckDuplicateClassroom = con.Query<int>(Constants.StoreProcedures.CheckDuplicateClassRoom, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return CheckDuplicateClassroom;
            }
        }

        public List<Class> GetActiveClass()
        {
            List<Class> classDetails = new List<Class>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                var result = con.Query<Class>(Constants.StoreProcedures.GetActiveClass, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    classDetails = result.ToList();
                }
            }
            return classDetails;
        }

        public List<ClassRoomName> GetActiveClassRoomName()
        {
            List<ClassRoomName> classDetails = new List<ClassRoomName>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                var result = con.Query<ClassRoomName>(Constants.StoreProcedures.GetActiveClassRoomName, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    classDetails = result.ToList();
                }
            }
            return classDetails;
        }

        public List<ClassRoomType> GetActiveClassRoomType()
        {
            List<ClassRoomType> classRoomType = new List<ClassRoomType>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                var result = con.Query<ClassRoomType>(Constants.StoreProcedures.GetActiveClassRoomType, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    classRoomType = result.ToList();
                }
            }
            return classRoomType;
        }

        public void DeleteClassRoom(int classRoomId)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inClassRoomId, classRoomId);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query(Constants.StoreProcedures.DeleteClassRoom, dynParam, commandType: CommandType.StoredProcedure);
            }

        }

        public ClassRoom GetClassRoomByClassRoomId(int ClassRoomId)
        {
            ClassRoom classRoomData = new ClassRoom();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inClassRoomId, ClassRoomId);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                classRoomData = con.Query<ClassRoom>(Constants.StoreProcedures.GetClassRoomByClassRoomId, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return classRoomData;
        }

        public int UpdateClassRoom(ClassRoom classRoom)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inClassRoomId, classRoom.ClassRoomId);
                spParam.Add(Constants.Parameters.inClassRoomName, classRoom.ClassRoomName);
                spParam.Add(Constants.Parameters.inClass, classRoom.Class);
                spParam.Add(Constants.Parameters.inClassRoomType, classRoom.ClassRoomType);
                spParam.Add(Constants.Parameters.inPrice, classRoom.Price);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.UpdateClassRoom, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);
            }

        }
    }
}
