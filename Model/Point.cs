using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class Point : IMovable
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get { return x; } }
        public double Y { get { return y; } }

        private double x;
        private double y;

        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
    }
}
