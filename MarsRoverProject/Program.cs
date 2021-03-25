using MarsRover.Entity.Entity;
using MarsRover.Entity.Enums;
using MarsRover.Entity.Model;
using MarsRover.Service.Abstract;
using MarsRover.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRoverProject
{
    class Program
    {
        private static IRoverService _roverService;
        private static ICommandService _commandService;
        private static IMarsGridService _marsGridService;

        static void Main(string[] args)
        {
            Startup();

            var marsGrid = _marsGridService.Create(new CraeteMarsGridModel(5, 5));

            marsGrid.Rovers.Add(new Rover(1, 2, EnumDirection.N));
            marsGrid.Rovers.Add(new Rover(3, 3, EnumDirection.E));

            _commandService.Command(marsGrid.Rovers[0], marsGrid, "LMLMLMLMM");
            _commandService.Command(marsGrid.Rovers[1], marsGrid, "MMRMMRMRRM");

            foreach (var rover in marsGrid.Rovers)
            {
                Console.WriteLine($"{ rover.XPosition}-{rover.YPosition}-{rover.Direction.ToString()}");
            }

            Console.ReadKey();

        }

        private static ServiceProvider Startup()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
          .AddSingleton<IRoverService, RoverManager>()
          .AddSingleton<IMarsGridService, MarsGridManager>()
          .AddSingleton<ICommandService, CommandManager>()
          .BuildServiceProvider();


            _roverService = serviceProvider.GetService<IRoverService>();
            _marsGridService = serviceProvider.GetService<IMarsGridService>();
            _commandService = serviceProvider.GetService<ICommandService>();

            return serviceProvider;
        }
    }
}
