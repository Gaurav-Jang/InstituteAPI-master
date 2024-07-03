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

        public int SetFeeStructure(FeeStructure feeStructure)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFeeStructureId, feeStructure.FeeStructureId);
                spParam.Add(Constants.Parameters.inClass, feeStructure.Class);
                spParam.Add(Constants.Parameters.inRegistrationFees, feeStructure.RegistrationFees);
                spParam.Add(Constants.Parameters.inAdmissionFees, feeStructure.AdmissionFees);
                spParam.Add(Constants.Parameters.inTutionFees, feeStructure.TutionFees);
                spParam.Add(Constants.Parameters.inWelcomeKit, feeStructure.WelcomeKit);
                spParam.Add(Constants.Parameters.inSchoolFees, feeStructure.SchoolFees);
                spParam.Add(Constants.Parameters.inMigrationCharges, feeStructure.MigrationCharges);
                spParam.Add(Constants.Parameters.inIsActive, feeStructure.IsActive);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.SetFeeStructure, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);
            }

        }




    }
}

