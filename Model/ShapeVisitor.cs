using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public abstract class ShapeVisitor
    {
        public abstract void Visit(Shape shape);
        public abstract void Visit(Rectangle rect);
        public abstract void Visit(Ellipse elipse);
    }
}