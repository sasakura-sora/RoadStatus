using Microsoft.Extensions.DependencyInjection;
using RoadStatus.Core;
using RoadStatus.Core.Data;
using RoadStatus.Core.Domain;
using System;
using System.Threading.Tasks;

namespace RoadStatus
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            if(args == null || args.Length == 0)
            {
                Console.WriteLine("Please provide a road id");
                return 2;
            }
                       

           //Setup DI in a console app as it's not provided
            var serviceProvider = new ServiceCollection()            
            .AddSingleton<IConfig, Config>()
            .AddSingleton<IRoadService, RoadService>()
            .AddSingleton<ITflClient, TflClient>()
            .BuildServiceProvider();

            var roadService = serviceProvider.GetService<IRoadService>();
            var roadId = args[0];

            var road = await roadService.GetStatus(roadId);
            
            if(road == null)
            {
                Console.WriteLine($"{roadId} is not a valid road");
                return 1;
            }

            Console.WriteLine($"The status of the {road.Name} is as follows");
            Console.WriteLine($"\tRoad Status is {road.Status}");
            Console.WriteLine($"\tRoad Status Description is {road.Description}");

            return 0;
        }
    }
}
