using Microsoft.Extensions.DependencyInjection;
using New_Era.Services.Services;

namespace New_Era.Services
{
    public static class ServicesDependencyInjection
    {
        public static IServiceCollection AddServicesDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IStudentServices, StudentServices>();
            return services;
        }
    }
}
