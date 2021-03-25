using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entity.Model
{
    public class CraeteMarsGridModel
    {
        public CraeteMarsGridModel(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
