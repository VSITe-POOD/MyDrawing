using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Elipse : Shape, IResizable, IMovable
    {
        public void Move(double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public void Resize(ResizeDirection direction, double dx, double dy)
        {
            throw new NotImplementedException();
        }
        public Point Center { get { return center; } }
        public double SemiaxisA { get { return semiaxisA; } }
        public double SemiaxisB { get { return semiaxisB; } }

        private Point center;
        private double semiaxisA;
        private double semiaxisB;
    }
}
