using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSite.POOD.MyDrawing.Model;

namespace VSite.POOD.MyDrawing.UnitTests
{
    [TestClass]
    public class TestDrawing
    {
        [TestMethod]
        public void AddShapeToDrawingIncreasesShapesList()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            drawing.Add(rect);
            Assert.AreEqual(1, drawing.Shapes.Count());
            Assert.IsTrue(drawing.Shapes.ElementAt(0) == rect);
        }

        [TestMethod]
        public void RemoveShapeFromDrawingDecreasesShapesList()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            drawing.Add(rect);
            drawing.Remove(rect);

            Assert.AreEqual(0, drawing.Shapes.Count());
        }
    }
}
