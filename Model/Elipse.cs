using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Ellipse : Shape, IResizable, IMovable
    {
        public Ellipse(double x, double y, double semiAxisA, double semiAxisB)
        {
            center = new Point(x, y);
            this.semiaxisA = semiAxisA;
            this.semiaxisB = semiAxisB;
        }
        public override void Move(double dx, double dy)
        {
            center.Move(dx, dy);
        }

        public override void Resize(ResizeDirection direction, double dx, double dy)
        {
            if ((direction & ResizeDirection.North) != 0)
            {
                center.Move(0, dy / 2);
                semiaxisB += dy / 2;
            }
            if ((direction & ResizeDirection.South) != 0)
            {
                center.Move(0, dy / 2);
                semiaxisB -= dy / 2;
            }
            if ((direction & ResizeDirection.West) != 0)
            {
                center.Move(dx / 2, 0);
                semiaxisA -= dx / 2;
            }
            if ((direction & ResizeDirection.East) != 0)
            {
                center.Move(dx / 2, 0);
                semiaxisA += dx / 2;
            }
        }
        public Point Center { get { return center; } }
        public double SemiAxisA { get { return semiaxisA; } }
        public double SemiAxisB { get { return semiaxisB; } }

        private Point center;
        private double semiaxisA;
        private double semiaxisB;
    }
}
