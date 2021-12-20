using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSite.POOD.MyDrawing.Model;

namespace VSite.POOD.MyDrawing.Model
{
    [TestClass]
    public class TestCheckVisiting
    {
        [TestMethod]
        public void ShapeVisitorVisitsAllShapesInDrawing()
        {
            Rectangle rect1 = new Rectangle(1, 2, 5, 6);
            Rectangle rect2 = new Rectangle(7, 8, 9, 10);
            Ellipse ellipse1 = new Ellipse(new Point(15, 18), 20, 13);

            Drawing drawing = new Drawing();
            drawing.Add(rect1);
            drawing.Add(ellipse1);
            drawing.Add(rect2);

            TestVisitor TV = new TestVisitor();
            drawing.Accept(TV);

            Assert.AreEqual(3, TV.visitedShapes.Count);
            Assert.AreSame(rect1, TV.visitedShapes[0]);
            Assert.AreSame(ellipse1, TV.visitedShapes[1]);
            Assert.AreSame(rect2, TV.visitedShapes[2]);
        }
    }
}
