using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Vsite.Pood.MyDrawing.Model
{
    public class WinFormsDrawingShapeVisitor : ShapeVisitor
    {
        public WinFormsDrawingShapeVisitor(Graphics g)
        {
            graphics = g;
        }
        public override void Visit(Shape shape)
        {
            throw new NotImplementedException();
        }

        public override void Visit(Rectangle rect)
        {
            graphics.DrawRectangle(Pens.Red, new System.Drawing.Rectangle((int)rect.LeftUpper.X, (int)rect.LeftUpper.Y, (int)rect.Width, (int)rect.Height));
        }

        public override void Visit(Ellipse ellipse)
        {
            graphics.DrawEllipse(Pens.Red, new System.Drawing.Rectangle((int)(ellipse.Center.X - ellipse.SemiAxisA), (int)(ellipse.Center.Y - ellipse.SemiAxisB),
                (int)(ellipse.SemiAxisA * 2), (int)(ellipse.SemiAxisB * 2)));
        }

        Graphics graphics;
    }
}
