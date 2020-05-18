using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using EFCoreTest.Entities;
using EFCoreTest.Interfaces;
using EFCoreTest.Repositories;
using EFCoreTest.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EFCoreTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();

            //DI
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ExternalJobContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                    options.EnableSensitiveDataLogging();
                }, ServiceLifetime.Singleton)
                .AddLogging(configure => configure.AddConsole())
                .AddScoped<IBulkService, BulkService>()
                .AddScoped<IWorkOrderRepository, WorkOrderRepository>()
                // Add other dependencies here ...
                .BuildServiceProvider();

            var bulkService = serviceProvider.GetRequiredService<IBulkService>();
            await bulkService.ProcessBulkOrders(new List<IWorkOrder>
            {
                new WorkOrder
                {
                    Number = "W1",
                    Name = "Test"
                },
                new WorkOrder
                {
                    Number = "W2",
                    Name = "Test"
                },
                new WorkOrder
                {
                    Number = "W3",
                    Name = "Test3"
                },
            });
        }
    }
}
