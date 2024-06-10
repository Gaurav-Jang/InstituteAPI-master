using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer.Repository
{
    public class BaseRepository
    {
        private readonly IConfiguration configuration;
        public BaseRepository(IConfiguration config)
        {
            configuration = config;
        }
        protected IDbConnection DBConnection
        {
            get
            {
                return new MySqlConnection(configuration.GetConnectionString("DBConnection"));
            }
        }
    }
}
