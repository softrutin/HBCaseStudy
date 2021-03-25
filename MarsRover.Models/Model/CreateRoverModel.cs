using MarsRover.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entity.Model
{
    public class CreateRoverModel
    {
        public int XPosition { get; set; }
        public int yPosition { get; set; }
        public EnumDirection Direction { get; set; }
    }
}
