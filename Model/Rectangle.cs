using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class Rectangle : Shape, IMovable, IResizable
    {
        public Rectangle(double X, double Y, double W, double H)
        {
            leftUpper = new Point(X, Y);
            width = W;
            height = H;
        }
        public override void Move(double dx, double dy)
        {
            leftUpper.Move(dx, dy);
        }

        public override void Resize(ResizeDirection RD, double dx, double dy)
        {
            if ((RD & ResizeDirection.North) != 0)
            {
                leftUpper.Move(0, dy);
                height += dy;
            }

            if ((RD & ResizeDirection.South) != 0)
            {
                height -= dy;
            }
            if ((RD & ResizeDirection.West) != 0)
            {
                leftUpper.Move(dx, 0);
                width -= dx;
            }
            if ((RD & ResizeDirection.East) != 0)
            {
                width += dx;
            }
        }

        public Point LeftUpper { get { return leftUpper; } }
        public double Width { get { return width; } }
        public double Height { get { return height; } }
        private Point leftUpper;
        private double width;
        private double height;
    }
}
