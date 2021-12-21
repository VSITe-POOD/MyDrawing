using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Ellipse : Shape, IResizeable, IMoveable, IHittable
    {
        public Ellipse(double dx, double dy, double semiaxisA, double semiaxisB)
        {
            center = new Point(dx, dy);
            this.semiaxisA = semiaxisA;
            this.semiaxisB = semiaxisB;   
        }
        public override void Move(double dx, double dy)
        {
            center.Move(dx, dy);
        }

        public override void Resize(ResizeDirection direction, double dx, double dy)
        {
            if ((direction & ResizeDirection.North) != 0)
            {
                center.Move(0, dy);
                semiaxisB += dy;
            }
            if ((direction & ResizeDirection.South) != 0)
            {
                semiaxisB -= dy;
            }
            if ((direction & ResizeDirection.West) != 0)
            {
                center.Move(dx, 0);
                semiaxisA -= dx;
            }
            if ((direction & ResizeDirection.East) != 0)
            {
                semiaxisA += dx;
            }
        }

        public override bool IsHit(double x, double y)
        {
            throw new NotImplementedException();
        }

        public Point Center { get { return center; } }
        public double SemiAxisA { get { return semiaxisA; } }
        public double SemiAxisB { get { return semiaxisB; } }

        private Point center;
        private double semiaxisA;
        private double semiaxisB;
    }
}
