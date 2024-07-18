using Dapper;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.FeeStructure;
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
    public class FeeStructureRepository : BaseRepository, IFeeStructureRepository
    {
        public FeeStructureRepository(IConfiguration config) : base(config)
        {

        }
        public List<FeeStructure> GetActiveFeeStructure()
        {
            List<FeeStructure> FeeStructureDetails = new List<FeeStructure>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                var result = con.Query<FeeStructure>(Constants.StoreProcedures.GetActiveFeeStructure, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    FeeStructureDetails = result.ToList();
                }
            }
            return FeeStructureDetails;
        }
        public List<FeeStructure> GetFeeStructureByClassRoom(string classRoomName)
        {
            List<FeeStructure> FeeStructureDetails = new List<FeeStructure>();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inStudentClassRoomNames, classRoomName);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<FeeStructure>(Constants.StoreProcedures.GetFeeStructureByClassRoom,dynParam, commandType: CommandType.StoredProcedure);
                if (result != null)
                {
                    FeeStructureDetails = result.ToList();
                }
            }
            return FeeStructureDetails;
        }
        public int SetFeeStructure(FeeStructure feeStructure)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStructureId, feeStructure.FeeStructureId);
                spParam.Add(Constants.Parameters.inStudentClassRoomNames, feeStructure.StudentClassRoomNames);
                spParam.Add(Constants.Parameters.inRegistrationFees, feeStructure.RegistrationFees);
                spParam.Add(Constants.Parameters.inAdmissionFees, feeStructure.AdmissionFees);
                spParam.Add(Constants.Parameters.inTuitionFees, feeStructure.TuitionFees);
                spParam.Add(Constants.Parameters.inWelcomeKit, feeStructure.WelcomeKit);
                spParam.Add(Constants.Parameters.inSchoolFees, feeStructure.SchoolFees);
                spParam.Add(Constants.Parameters.inExamFees, feeStructure.ExamFees);
                spParam.Add(Constants.Parameters.inMigrationCharges, feeStructure.MigrationCharges);
                spParam.Add(Constants.Parameters.inIsActive, feeStructure.IsActive);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.SetFeeStructure, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);
            }

        }
        public void DeleteFeeStructure(int FeeStructureId)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStructureId, FeeStructureId);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query(Constants.StoreProcedures.DeleteFeeStructure, dynParam, commandType: CommandType.StoredProcedure);
            }

        }
        public FeeStructure GetFeeStructureByFeeStructureId(int FeeStructureId)
        {
            FeeStructure feeStructureData = new FeeStructure();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStructureId, FeeStructureId);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                feeStructureData = con.Query<FeeStructure>(Constants.StoreProcedures.GetFeeStructureByFeeStructureId, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return feeStructureData;
        }
        public int UpdateFeeStructure(FeeStructure feeStructure)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStructureId, feeStructure.FeeStructureId);
                spParam.Add(Constants.Parameters.inStudentClassRoomNames, feeStructure.StudentClassRoomNames);
                spParam.Add(Constants.Parameters.inRegistrationFees, feeStructure.RegistrationFees);
                spParam.Add(Constants.Parameters.inAdmissionFees, feeStructure.AdmissionFees);
                spParam.Add(Constants.Parameters.inTuitionFees, feeStructure.TuitionFees);
                spParam.Add(Constants.Parameters.inWelcomeKit, feeStructure.WelcomeKit);
                spParam.Add(Constants.Parameters.inSchoolFees, feeStructure.SchoolFees);
                spParam.Add(Constants.Parameters.inExamFees, feeStructure.ExamFees);
                spParam.Add(Constants.Parameters.inMigrationCharges, feeStructure.MigrationCharges);
                spParam.Add(Constants.Parameters.inIsActive, feeStructure.IsActive);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.UpdateFeeStructure, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);
            }

        }
        public int CheckDuplicateFeeStructure(FeeStructure feeStructure)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStructureId, feeStructure.FeeStructureId);
                spParam.Add(Constants.Parameters.inStudentClassRoomNames, feeStructure.StudentClassRoomNames);
                spParam.Add(Constants.Parameters.inRegistrationFees, feeStructure.RegistrationFees);
                spParam.Add(Constants.Parameters.inAdmissionFees, feeStructure.AdmissionFees);
                spParam.Add(Constants.Parameters.inTuitionFees, feeStructure.TuitionFees);
                spParam.Add(Constants.Parameters.inWelcomeKit, feeStructure.WelcomeKit);
                spParam.Add(Constants.Parameters.inSchoolFees, feeStructure.SchoolFees);
                spParam.Add(Constants.Parameters.inMigrationCharges, feeStructure.MigrationCharges);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var CheckDuplicateFeeStructure = con.Query<int>(Constants.StoreProcedures.CheckDuplicateFeeStructure, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return CheckDuplicateFeeStructure;
            }
        }
    }
}

