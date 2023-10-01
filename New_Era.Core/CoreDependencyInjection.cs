namespace New_Era.Core
{
    public static class CoreDependencyInjection
    {
        public static IServiceCollection AddCoreDependencyInjection(this IServiceCollection services)
        {
            //Mediator
            services.AddMediatR(option => option.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
