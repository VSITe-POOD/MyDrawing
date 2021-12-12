
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Vsite.Pood.MyDrawing.Model;


namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestEllipse
    {
        [TestMethod]
        public void MoveDisplacesEllipseBy2and5()
        {
            Ellipse ellipse = new Ellipse(4, 5, 20, 15);
            ellipse.Move(2, 5);
            Assert.AreEqual(6, ellipse.Center.X);
            Assert.AreEqual(10, ellipse.Center.Y);
            Assert.AreEqual(20, ellipse.SemiAxisA);
            Assert.AreEqual(15, ellipse.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnEastBy2IncreaseEllipseSemiAxisABy1()
        {
            Ellipse ellipse = new Ellipse(4, 5, 20, 15);
            ellipse.Resize(ResizeDirection.East, 2, 0);
            Assert.AreEqual(5, ellipse.Center.X);
            Assert.AreEqual(5, ellipse.Center.Y);
            Assert.AreEqual(21, ellipse.SemiAxisA);
            Assert.AreEqual(15, ellipse.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnWestBy2DecreaseEllipseSemiAxisABy1()
        {
            Ellipse ellipse = new Ellipse(4, 5, 20, 15);
            ellipse.Resize(ResizeDirection.West, 2, 0);
            Assert.AreEqual(5, ellipse.Center.X);
            Assert.AreEqual(5, ellipse.Center.Y);
            Assert.AreEqual(19, ellipse.SemiAxisA);
            Assert.AreEqual(15, ellipse.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnNorthBy4IncreaseElipseSemiAxisBBy2()
        {
            Ellipse ellipse = new Ellipse(4, 5, 20, 15);
            ellipse.Resize(ResizeDirection.North, 0, 4);
            Assert.AreEqual(4, ellipse.Center.X);
            Assert.AreEqual(7, ellipse.Center.Y);
            Assert.AreEqual(20, ellipse.SemiAxisA);
            Assert.AreEqual(17, ellipse.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnSouthBy4DecreaseEllipseSemiAxisBBy2()
        {
            Ellipse ellipse = new Ellipse(4, 5, 20, 15);
            ellipse.Resize(ResizeDirection.South, 0, 4);
            Assert.AreEqual(4, ellipse.Center.X);
            Assert.AreEqual(7, ellipse.Center.Y);
            Assert.AreEqual(20, ellipse.SemiAxisA);
            Assert.AreEqual(13, ellipse.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnNorthWestBy6x4DecreaseElipseleSemiaxisABy3IncreaseSemiAxisBBy2()
        {
            Ellipse ellipse = new Ellipse(4, 5, 20, 15);
            ellipse.Resize(ResizeDirection.NorthWest, 6, 4);
            Assert.AreEqual(7, ellipse.Center.X);
            Assert.AreEqual(7, ellipse.Center.Y);
            Assert.AreEqual(17, ellipse.SemiAxisA);
            Assert.AreEqual(17, ellipse.SemiAxisB);
        }
    }
}