using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public abstract class Shape : IMovable, IResizable
    {
        abstract public void Move(double dx, double dy);

        abstract public void Resize(ResizeDirection RD, double dx, double dy);
    }
}