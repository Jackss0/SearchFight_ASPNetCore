using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SearchFight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Initializer.LaunchingApp(args);
            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}