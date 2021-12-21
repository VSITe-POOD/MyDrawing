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
        Graphics graphics;
        public WinFormsDrawingShapeVisitor(System.Drawing.Graphics graphics)
        {
            this.graphics = graphics;
        }
        public override void Visit(Rectangle rect)
        {
            graphics.DrawRectangle(Pens.Red, new System.Drawing.Rectangle((int)rect.LeftUpper.X, (int)rect.LeftUpper.Y,
                (int)rect.Width, (int)rect.Height));
        }

        public override void Visit(Shape shape)
        {
            throw new NotImplementedException();
        }

        public override void Visit(Ellipse elipse)
        {
            graphics.DrawEllipse(Pens.Red, new System.Drawing.Rectangle((int)(elipse.Center.X - elipse.SemiAxisA), (int)(elipse.Center.Y -
                elipse.SemiAxisB), (int)elipse.SemiAxisA * 2, (int)elipse.SemiAxisB * 2));
        }
    }
}

