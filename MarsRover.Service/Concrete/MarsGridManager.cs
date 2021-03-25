using MarsRover.Entity.Entity;
using MarsRover.Entity.Model;
using MarsRover.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service.Concrete
{
    public class MarsGridManager : IMarsGridService
    {
        public MarsGrid Create(CraeteMarsGridModel model)
        {
            return new MarsGrid(model.Width, model.Height);
        }
    }
}
