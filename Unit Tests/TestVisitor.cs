using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class TestVisitor : ShapeVisitor
    {
        public override void Visit(Shape shape)
        {
            throw new NotImplementedException();
        }

        public override void Visit(Rectangle rect)
        {
            visitedShapes.Add(rect);
        }

        public override void Visit(Ellipse ellipse)
        {
            visitedShapes.Add(ellipse);
        }

        public List<Shape> visitedShapes = new List<Shape>();
    
        
    }
}
