using MarsRover.Entity.Entity;
using MarsRover.Entity.Enums;
using MarsRover.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service.Concrete
{
    public class CommandManager : ICommandService
    {
        public void Command(Rover rover, MarsGrid grid, string commandStr)
        {
            foreach (var command in commandStr)
            {
                rover = RunCommand(rover, grid, (EnumMove)command);
            }
        }

        public Rover RunCommand(Rover rover, MarsGrid grid, EnumMove move)
        {
            switch (move)
            {
                case EnumMove.Left:
                    rover.Direction = (rover.Direction - 90) < EnumDirection.N ? EnumDirection.W : rover.Direction - 90;
                    break;
                case EnumMove.Right:
                    rover.Direction = (rover.Direction + 90) > EnumDirection.W ? EnumDirection.N : rover.Direction + 90;
                    break;
                case EnumMove.Move:
                    if (rover.Direction == EnumDirection.N && grid.Height > rover.YPosition)
                    {
                        rover.YPosition++;
                    }
                    else if (rover.Direction == EnumDirection.E && grid.Width > rover.XPosition)
                    {
                        rover.XPosition++;
                    }
                    else if (rover.Direction == EnumDirection.S && rover.YPosition > 0)
                    {
                        rover.YPosition--;
                    }
                    else if (rover.Direction == EnumDirection.W && rover.XPosition > 0)
                    {
                        rover.XPosition--;
                    }
                    break;             
            }

            return rover;
        }

    }
}
