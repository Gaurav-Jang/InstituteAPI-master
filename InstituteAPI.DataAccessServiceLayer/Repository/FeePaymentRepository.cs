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

        public List<FeePayment> GetActiveFeesPayment()
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
        public int SetFeesPayment(FeePayment feePayment)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStudentFirstName, feePayment.StudentFirstName);
                spParam.Add(Constants.Parameters.inFeeDob, feePayment.Dob);
                spParam.Add(Constants.Parameters.inFeeFatherFirstName, feePayment.FatherFirstName);
                spParam.Add(Constants.Parameters.inFeeStudentClassRoomName, feePayment.StudentClassRoomName);
                spParam.Add(Constants.Parameters.inFeeAvailingTransport, feePayment.AvailingTransport);
                spParam.Add(Constants.Parameters.inFeeAvailingSchool, feePayment.AvailingSchool);
                spParam.Add(Constants.Parameters.inFeeAvailingHostel, feePayment.AvailingHostel);
                spParam.Add(Constants.Parameters.inFeeRegistrationFees, feePayment.RegistrationFees);
                spParam.Add(Constants.Parameters.inFeeAdmissionFees, feePayment.AdmissionFees);
                spParam.Add(Constants.Parameters.inFeeTuitionFees, feePayment.TuitionFees);
                spParam.Add(Constants.Parameters.inFeeWelcomeKit, feePayment.WelcomeKit);
                spParam.Add(Constants.Parameters.inFeeSchoolFees, feePayment.SchoolFees);
                spParam.Add(Constants.Parameters.inFeeExamFees, feePayment.ExamFees);
                spParam.Add(Constants.Parameters.inFeeMigrationCharges, feePayment.MigrationCharges);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.SetFeesPayment, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);

            }

        }
        public int CheckDuplicateFeesPayment(FeePayment feePayment)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStudentFirstName, feePayment.StudentFirstName);
                spParam.Add(Constants.Parameters.inFeeDob, feePayment.Dob);
                spParam.Add(Constants.Parameters.inFeeFatherFirstName, feePayment.FatherFirstName);
                spParam.Add(Constants.Parameters.inFeeStudentClassRoomName, feePayment.StudentClassRoomName);
                spParam.Add(Constants.Parameters.inFeeAvailingTransport, feePayment.AvailingTransport);
                spParam.Add(Constants.Parameters.inFeeAvailingSchool, feePayment.AvailingSchool);
                spParam.Add(Constants.Parameters.inFeeAvailingHostel, feePayment.AvailingHostel);
                spParam.Add(Constants.Parameters.inFeeRegistrationFees, feePayment.RegistrationFees);
                spParam.Add(Constants.Parameters.inFeeAdmissionFees, feePayment.AdmissionFees);
                spParam.Add(Constants.Parameters.inFeeTuitionFees, feePayment.TuitionFees);
                spParam.Add(Constants.Parameters.inFeeWelcomeKit, feePayment.WelcomeKit);
                spParam.Add(Constants.Parameters.inFeeSchoolFees, feePayment.SchoolFees);
                spParam.Add(Constants.Parameters.inFeeExamFees, feePayment.ExamFees);
                spParam.Add(Constants.Parameters.inFeeMigrationCharges, feePayment.MigrationCharges);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var CheckDuplicateFeePayment = con.Query<int>(Constants.StoreProcedures.CheckDuplicateFeesPayment, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return CheckDuplicateFeePayment;
            }
        }
        public void DeleteFeesPayment(int feePaymentId)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeePaymentId, feePaymentId);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query(Constants.StoreProcedures.DeleteFeesPayment, dynParam, commandType: CommandType.StoredProcedure);
            }

        }
        public FeePayment GetFeesPaymentByFeesPaymentId(int feePaymentId)
        {
            FeePayment FeePaymentData = new FeePayment();
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeePaymentId, feePaymentId);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                FeePaymentData = con.Query<FeePayment>(Constants.StoreProcedures.GetFeesPaymentByFeesPaymentId, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return FeePaymentData;
        }
        public int UpdateFeesPayment(FeePayment feePayment)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStudentFirstName, feePayment.StudentFirstName);
                spParam.Add(Constants.Parameters.inFeeDob, feePayment.Dob);
                spParam.Add(Constants.Parameters.inFeeFatherFirstName, feePayment.FatherFirstName);
                spParam.Add(Constants.Parameters.inFeeStudentClassRoomName, feePayment.StudentClassRoomName);
                spParam.Add(Constants.Parameters.inFeeAvailingTransport, feePayment.AvailingTransport);
                spParam.Add(Constants.Parameters.inFeeAvailingSchool, feePayment.AvailingSchool);
                spParam.Add(Constants.Parameters.inFeeAvailingHostel, feePayment.AvailingHostel);
                spParam.Add(Constants.Parameters.inFeeRegistrationFees, feePayment.RegistrationFees);
                spParam.Add(Constants.Parameters.inFeeAdmissionFees, feePayment.AdmissionFees);
                spParam.Add(Constants.Parameters.inFeeTuitionFees, feePayment.TuitionFees);
                spParam.Add(Constants.Parameters.inFeeWelcomeKit, feePayment.WelcomeKit);
                spParam.Add(Constants.Parameters.inFeeSchoolFees, feePayment.SchoolFees);
                spParam.Add(Constants.Parameters.inFeeExamFees, feePayment.ExamFees);
                spParam.Add(Constants.Parameters.inFeeMigrationCharges, feePayment.MigrationCharges);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.UpdateFeesPayment, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);
            }

        }
    }
}
