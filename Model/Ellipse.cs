using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class Ellipse : Shape, IResizable, IMovable, IHittable
    {
        public Ellipse(Point center, double semiAxisA, double semiAxisB)
        {
            Center = center;
            SemiAxisA = semiAxisA;
            SemiAxisB = semiAxisB;
        }
        public override void Move(double dx, double dy)
        {
            Center.Move(dx, dy);
        }

        public override void Resize(ResizeDirection RD, double dx, double dy)
        {
            if ((RD & ResizeDirection.North) != 0)
            {
                SemiAxisA += dy;
            }

            if ((RD & ResizeDirection.South) != 0)
            {
                SemiAxisA -= dy;
            }
            if ((RD & ResizeDirection.West) != 0)
            {
                SemiAxisB -= dx;
            }
            if ((RD & ResizeDirection.East) != 0)
            {
                SemiAxisB += dx;
            }
        }

        public override bool IsHit(double x, double y)
        {
            throw new NotImplementedException();
        }

        public Point center { get { return Center; } } 
        public double semiAxisA { get { return SemiAxisA; } } 
        public double semiAxisB { get { return SemiAxisB; } } 

        private Point Center;
        private double SemiAxisA;
        private double SemiAxisB;
    }
}
