using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VSite.POOD.MyDrawing.Model
{
    public class WinFormsDrawingShapeVisitor : ShapeVisitor
    {
        public WinFormsDrawingShapeVisitor(System.Drawing.Graphics g)
        {
            graphics = g;
        }

        System.Drawing.Graphics graphics;
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
            graphics.DrawRectangle(Pens.Red, new System.Drawing.Rectangle((int)(ellipse.center.X - ellipse.semiAxisA), (int)(ellipse.center.Y - ellipse.semiAxisB), (int)ellipse.semiAxisA * 2, (int)ellipse.semiAxisB * 2));
        }
    }
}
