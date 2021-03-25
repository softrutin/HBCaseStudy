using MarsRover.Entity.Enums;

namespace MarsRover.Entity.Entity
{
    public class Rover
    {
        public Rover(int xPosition, int yPosition, EnumDirection direction)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            Direction = direction;
        }

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public EnumDirection Direction { get; set; }
    }
}
