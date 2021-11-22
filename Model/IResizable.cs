using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public enum ResizeDirection
    {
        North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest
    }
    public interface IResizable
    {
        public void Resize(ResizeDirection RD, double dx, double dy);


    }
}
