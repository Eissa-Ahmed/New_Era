namespace New_Era.API
{
    public static class APIDependencyInjection
    {

        public static IServiceCollection AddAPIDependencyInjection(this IServiceCollection services)
        {
            //Configration Language
            services.AddControllersWithViews();
            services.AddLocalization(option => option.ResourcesPath = "");
            services.Configure<RequestLocalizationOptions>(option =>
            {
                var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("ar")
            };
                option.SetDefaultCulture("en");
                option.DefaultRequestCulture = new RequestCulture("en");
                option.SupportedCultures = supportedCultures;
                option.SupportedUICultures = supportedCultures;
                option.RequestCultureProviders = new List<IRequestCultureProvider>
        {
            new QueryStringRequestCultureProvider(),
            new CookieRequestCultureProvider()
        };
            });
            //

            return services;
        }
    }
}
