using System;
using System.Threading.Tasks;
using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            await Task.Delay(1);

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICommonService, FooService>()
                .AddLogging(builder =>
                {
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddNLog(new NLogProviderOptions
                    {
                        CaptureMessageTemplates = true,
                        CaptureMessageProperties = true
                    });
                })
                .BuildServiceProvider();

            // Replace Program with the class
            ILogger<Program> logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Program>();
            
            logger.LogInformation("Starting application...");

            var fooService = serviceProvider.GetService<ICommonService>();
            fooService.Execute();

            Console.WriteLine("Press a key");
            Console.ReadLine();

        }


    }
}
