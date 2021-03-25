using System.Collections.Generic;

namespace MarsRover.Entity.Entity
{
    public class MarsGrid
    {
        public MarsGrid(int width, int height)
        {
            Width = width;
            Height = height;
            Rovers = new List<Rover>();
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public List<Rover> Rovers { get; set; }
    }
}
