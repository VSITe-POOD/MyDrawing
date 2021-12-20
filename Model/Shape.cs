using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    abstract public class Shape : IMovable, IResizable, IHittable
    {
        public abstract bool IsHit(double X, double y);
        abstract public void Move(double dx, double dy);

        abstract public void Resize(ResizeDirection direction, double dx, double dy);
    }
}
