using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace McRest
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

                host.Run();
            // using (var host = new NancyHost(new Uri("http://localhost:1234")))
            // {
            //     host.Start();
            //     Console.WriteLine("Running on http://localhost:1234");
            //     Console.ReadLine();
            //     host.Stop();

            // }
        }
    }
}
