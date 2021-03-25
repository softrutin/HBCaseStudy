using MarsRover.Entity.Entity;
using MarsRover.Entity.Model;

namespace MarsRover.Service.Abstract
{
    public interface IMarsGridService
    {
        public MarsGrid Create(CraeteMarsGridModel model);
    }
}
