using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SupportTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var workingDir = Directory.GetCurrentDirectory();

            WebHost.CreateDefaultBuilder(args)
                .UseContentRoot(Path.Combine(workingDir, "src/app"))
                .UseStartup<Startup>()
                .Build()
                .Run();
        }  
    }
}