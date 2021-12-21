using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Rectangle : Shape, IMoveable, IResizeable, IHittable
    {
        public Rectangle(double x, double y, double width, double height)
        {
            leftUpper = new Point(x, y);
            this.width = width;
            this.height = height;
        }
        public override void Move(double dx, double dy)
        {
            leftUpper.Move(dx, dy);
        }
        public override void Resize(ResizeDirection direction, double dx, double dy)
        {
            if((direction & ResizeDirection.North) != 0) 
            {
                leftUpper.Move(0, dy);
                height += dy;
            }
            if ((direction & ResizeDirection.South) != 0)
            {
                height -= dy;
            }
            if ((direction & ResizeDirection.West) != 0)
            {
                leftUpper.Move(dx, 0);
                width -= dx;
            }
            if ((direction & ResizeDirection.East) != 0)
            {
                width += dx;
            }
        }
        public override bool IsHit(double x, double y)
        {
            return (x >= leftUpper.X && x <= leftUpper.X + width) && (y >= leftUpper.Y - Height && y <= leftUpper.Y);
        }

        public Point LeftUpper { get { return leftUpper; } }
        public double Width { get { return width; } }
        public double Height { get { return height; } }

        private Point leftUpper;
        private double width;
        private double height;
    }
}