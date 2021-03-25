using MarsRover.Entity.Entity;
using MarsRover.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service.Abstract
{
    public interface ICommandService
    {
        public void Command(Rover rover, MarsGrid grid, string commandStr);
        Rover RunCommand(Rover rover, MarsGrid grid, EnumMove move);
    }
}
