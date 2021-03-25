using MarsRover.Entity.Entity;
using MarsRover.Entity.Model;
using MarsRover.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service.Concrete
{
    public class RoverManager : IRoverService
    {
        public Rover Create(CreateRoverModel model)
        {
            return new Rover(model.XPosition, model.yPosition, model.Direction);
        }
    }
}
