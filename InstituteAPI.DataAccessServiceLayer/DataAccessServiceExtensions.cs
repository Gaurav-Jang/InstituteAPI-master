using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.DataAccessServiceLayer.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InstituteAPI.DataAccessServiceLayer
{
    public static class DataAccessServiceExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Repositories
            services.AddTransient<IClassRoomRepository, ClassRoomRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<ISupportRepository, SupportRepository>();
            #endregion
        }
    }
}
