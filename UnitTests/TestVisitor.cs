using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestVisitor : ShapeVisitor
    {
        public override void Visit(Shape shape)
        {
            visitedShapes.Add(shape);
        }

        public override void Visit(Rectangle rect)
        {
            visitedShapes.Add(rect);
        }

        public override void Visit(Ellipse elipse)
        {
            visitedShapes.Add(elipse);
        }

        public List<Shape> visitedShapes = new List<Shape>();
    }
}