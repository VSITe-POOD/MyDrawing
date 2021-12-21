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
    public class TestVisiting
    {
        [TestMethod]
        public void ShapeVisitorVisitsAllShapesInDrawing()
        {
            Rectangle rect1 = new Rectangle(1, 2, 5, 6);
            Rectangle rect2 = new Rectangle(7, 8, 9, 10);
            Ellipse elipse = new Ellipse(15, 18, 20, 13);

            Drawing drawing = new Drawing();
            drawing.Add(rect1);
            drawing.Add(rect2);
            drawing.Add(elipse);

            TestVisitor tv = new TestVisitor();
            drawing.AcceptShapeVisitor(tv);

            Assert.AreEqual(tv.visitedShapes.Count(), 3);
            Assert.AreSame(rect1, tv.visitedShapes[0]);
            Assert.AreSame(rect2, tv.visitedShapes[1]);
            Assert.AreSame(elipse, tv.visitedShapes[2]);
        }
    }
}