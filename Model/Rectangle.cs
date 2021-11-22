using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class Rectangle : IMovable, IResizable
    {
        public Rectangle(double X, double Y, double W, double H)
        {
            leftUpper = new Point(X, Y);
            width = W;
            height = H;
        }
        public void Move(double dx, double dy)
        {
            leftUpper.Move(dx, dy);
        }

        public void Resize(ResizeDirection RD, double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public Point LeftUpper { get { return leftUpper; } }
        public double Width { get { return width; } }
        public double Height { get { return height; } }
        private Point leftUpper;
        private double width;
        private double height;
    }
}
