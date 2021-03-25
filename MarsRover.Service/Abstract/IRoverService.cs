using MarsRover.Entity.Entity;
using MarsRover.Entity.Model;

namespace MarsRover.Service.Abstract
{
    public interface IRoverService
    {
        public Rover Create(CreateRoverModel model);
    }
}
