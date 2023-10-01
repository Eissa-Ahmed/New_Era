using New_Era.Infrastructure.Repository;

namespace New_Era.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("ApplicationConnection")));
            services.AddScoped<IStudentRepo, StudentRepo>();
            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            return services;
        }
    }
}
