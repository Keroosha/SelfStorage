using System;
using System.Threading.Tasks;
using Grains;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;

namespace Silo
{
    class Program
    {
        private const string ShutdownString = "Press enter to shutdown";
        private const string ClusterId = "dev";
        private const string ServiceId = "test";
        
        private static async Task<int> RunMainAsync()
        {
            try
            {
                var host = await StartSilo();
                Console.WriteLine(ShutdownString);
                Console.ReadLine();

                await host.StopAsync();

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }
        }
        
        private static async Task<ISiloHost> StartSilo()
        {
            var siloBuilder = new SiloHostBuilder()
                .UseLocalhostClustering()
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = ClusterId;
                    options.ServiceId = ServiceId;
                })
                .ConfigureApplicationParts(parts => parts
                    .AddApplicationPart(typeof(HelloGrain).Assembly)
                    .WithReferences())
                    .ConfigureLogging(logging => logging.AddConsole()
                );

            var host = siloBuilder.Build();
            await host.StartAsync();

            return host;
        }
        
        static async Task<int> Main(string[] args)
        {
            return await RunMainAsync();
        }
    }
}