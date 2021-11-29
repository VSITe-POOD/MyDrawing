using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class Ellipse : IResizable, IMovable
    {
        public void Move(double dx, double dy)
        {
            // dz
            throw new NotImplementedException();
        }

        public void Resize(ResizeDirection RD, double dx, double dy)
        {
            // dz
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
