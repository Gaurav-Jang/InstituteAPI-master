using Dapper;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.Support;
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
    public class SupportRepository : BaseRepository, ISupportRepository
    {
        public SupportRepository(IConfiguration config) : base(config)
        {

        }
        public int SetSupport(Support support)
        {
            using (IDbConnection con = DBConnection)
            {
                con.Open();
                Dictionary<string, object> spParam = new Dictionary<string, object>();
                spParam.Add(Constants.Parameters.inFullName, support.FullName);
                spParam.Add(Constants.Parameters.inEmail, support.Email);
                spParam.Add(Constants.Parameters.inSubject, support.Subject);
                spParam.Add(Constants.Parameters.inMessage, support.Message);
                DynamicParameters dynParam = new DynamicParameters(spParam);
                var result = con.Query<int>(Constants.StoreProcedures.SetSupport, dynParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Convert.ToInt32(result);

            }
        }
    }
}
