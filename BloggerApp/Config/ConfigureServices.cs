namespace BloggerApp.Config
{
    public class ConfigureServices
    {

        public static void ConfigurationServices(IServiceCollection services)
        {
            // To Register HttpClient for dependency injection
            services.AddHttpClient();
        }
    }
}
