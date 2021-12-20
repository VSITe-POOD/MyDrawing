using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Rectangle : Shape, IMovable, IResizable, IHittable
    {
        private Point leftUpper;
        private double width;
        private double height;

        public Point LeftUpper
        {
            get { return this.leftUpper; }
        }
        public double Width
        {
            get { return this.width; }
        }
        public double Height
        {
            get { return this.height; }
        }
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
                this.LeftUpper.Move(0, dy);
                this.height += dy;
            }
            if ((direction & ResizeDirection.South) != 0)
            {
                this.height -= dy;
            }
            if ((direction & ResizeDirection.West) != 0)
            {
                this.LeftUpper.Move(dx, 0);
                this.width -= dx;
            }
            if ((direction & ResizeDirection.East) != 0)
            {
                this.width += dx;
            }
            

        }

        public override bool IsHit(double x, double y)
        {
            return (x >= leftUpper.X && x <= leftUpper.X + width) && (y >= leftUpper.Y - Height && y <= leftUpper.Y);
        }

        public override void Accept(ShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
