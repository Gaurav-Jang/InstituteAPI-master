using Dapper;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.Class;
using InstituteAPI.Models.ClassRoom;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer.Repository
{
    public class ClassRoomRepository : BaseRepository, IClassRoomRepository
    {
        public ClassRoomRepository(IConfiguration config) : base(config)
        {

        }

        public List<ClassRoom> GetActiveClassRoom()
        {
            List<ClassRoom> classRoomDetails = new List<ClassRoom>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                var result = con.Query<ClassRoom>(Constants.StoreProcedures.GetActiveClassRoom, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    classRoomDetails = result.ToList();
                }
            }
            return classRoomDetails;
        }
        public int SetClassRoom(ClassRoom classRoom)
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
