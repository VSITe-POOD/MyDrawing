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

        public Point Center
        {
            get { return this.center; }
        }
        public double SemiAxisA
        {
            get { return this.semi_axisA; }
        }
        public double SemiAxisB
        {
            get { return this.semi_axisB; }
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
