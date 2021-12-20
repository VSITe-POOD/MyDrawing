using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public abstract class Shape : IMovable, IResizable, IHittable
    {
        public abstract bool IsHit(double X, double y);
        public abstract void Move(double dx, double dy);

        public abstract void Resize(ResizeDirection direction, double dx, double dy);

        public abstract void Accept(ShapeVisitor visitor);
    }
}
