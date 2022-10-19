using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public enum Direction
    {
        North,
        NorthEast,
        East,
        EastSouth,
        South,
        SouthWest,
        West,
        NorthWest
    }
    public interface IResize
    {
        void Resze(double dx, double dy, Direction direction);
    }
}
