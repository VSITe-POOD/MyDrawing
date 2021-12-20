using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests {
    [TestClass]
    public class TestVisiting {
        [TestMethod]
        public void ShapeVisitorVisitsAllShapesInDrawing() {
            Rectangle rect1 = new Rectangle(1, 2, 5, 6);
            Rectangle rect2 = new Rectangle(7, 8, 9, 10);
            Ellipse ellipse1 = new Ellipse(15, 18, 20, 13);

            Drawing drawing = new Drawing();
            drawing.Add(rect1);
            drawing.Add(ellipse1);
            drawing.Add(rect2);

            TestVisitor tv = new TestVisitor();
            drawing.Accept(tv);

            Assert.AreEqual(3, tv.visitedShapes.Count);
            Assert.AreSame(rect1, tv.visitedShapes[0]);
            Assert.AreSame(ellipse1, tv.visitedShapes[1]);
            Assert.AreSame(rect2, tv.visitedShapes[2]);
        }

    }
}
