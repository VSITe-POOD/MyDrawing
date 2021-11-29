
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Vsite.Pood.MyDrawing.Model;


    namespace Vsite.Pood.MyDrawing.UnitTests
    {
        [TestClass]
        public class TestDrawing
    {
        [TestMethod]
        public void AddShapeToDrawingIncreaseShapesList()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            drawing.Add(rect);
            Assert.AreEqual(1, drawing.Shapes.Count());
            Assert.IsTrue(drawing.Shapes.ElementAt(0) == rect);
        }
        [TestMethod]
        public void RemoveShapeFromDrawingDecreaseShapesList()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            drawing.Remove(rect);
            Assert.AreEqual(0, drawing.Shapes.Count());
        }
    }
}

