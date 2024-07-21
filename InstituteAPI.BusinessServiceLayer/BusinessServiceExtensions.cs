using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.BusinessServiceLayer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InstituteAPI.BusinessServiceLayer
{
    public static class BusinessServiceExtensions
    {
        public static void AddBusinessInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Repositories
            services.AddTransient<IClassRoomService, ClassRoomService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ISupportService, SupportService>();
            services.AddTransient<IFeeStructureService, FeeStructureService>();
            services.AddTransient<IFeePaymentService, FeePaymentService>();
            #endregion
        }
    }
}
