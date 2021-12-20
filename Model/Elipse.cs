using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Elipse : Shape, IResizable, IMovable, IHittable
    {
        private Point center;
        private double semi_axisA;
        private double semi_axisB;

        public Elipse(double xCenter, double yCenter, double semiAxisA, double semiAxisB)
        {
            
        }
        public Point Center
        {
            get { return this.center; }
            set { this.center = value; }
        }
        public double SemiAxisA
        {
            get { return this.semi_axisA; }
            set { this.semi_axisA = value; }
        }
        public double SemiAxisB
        {
            get { return this.semi_axisB; }
            set { this.semi_axisB = value; }
        }

        public override void Accept(ShapeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override bool IsHit(double x, double y)
        {
            throw new NotImplementedException();
        }

        public override void Move(double dx, double dy)
        {
            //Domaća zadaća
            throw new NotImplementedException();
        }

        public override void Resize(ResizeDirection direction, double dx, double dy)
        {
            //Domaća zadaća
            throw new NotImplementedException();
        }
    }
}
