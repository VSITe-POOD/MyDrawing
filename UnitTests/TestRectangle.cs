using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestRectangle
    {
        [TestMethod]
        public void MoveDisplacesRectangleBy2And5()
        {
            Rectangle rectangle = new Rectangle(4, 5, 20, 10);
            rectangle.Move(2, 5);
            Assert.AreEqual(6, rectangle.LeftUpper.X);
            Assert.AreEqual(10, rectangle.LeftUpper.Y);
            Assert.AreEqual(20, rectangle.Width);
            Assert.AreEqual(10, rectangle.Height);

        }
        [TestMethod]
        public void ResizeOnEastBy2IncreasesRectangleWidthBy2()
        {
            Rectangle rectangle = new Rectangle(4, 5, 20, 10);
            rectangle.Resize(ResizeDirection.East, 2, 0);
            Assert.AreEqual(4, rectangle.LeftUpper.X);
            Assert.AreEqual(5, rectangle.LeftUpper.Y);
            Assert.AreEqual(22, rectangle.Width);
            Assert.AreEqual(10, rectangle.Height);

        }

        [TestMethod]
        public void ResizeOnWestBy2DecreasesRectangleWidthBy2AndMovesUpperXBy2()
        {
            Rectangle rectangle = new Rectangle(4, 5, 20, 10);
            rectangle.Resize(ResizeDirection.West, 2, 0);
            Assert.AreEqual(6, rectangle.LeftUpper.X);
            Assert.AreEqual(5, rectangle.LeftUpper.Y);
            Assert.AreEqual(18, rectangle.Width);
            Assert.AreEqual(10, rectangle.Height);
        }
        [TestMethod]
        public void ResizeOnNorthBy3IncreasesRectangleHeightBy3AndMovesLeftUpperYBy3()
        {
            Rectangle rectangle = new Rectangle(4, 5, 20, 10);
            rectangle.Resize(ResizeDirection.North, 0, 3);
            Assert.AreEqual(4, rectangle.LeftUpper.X);
            Assert.AreEqual(8, rectangle.LeftUpper.Y);
            Assert.AreEqual(20, rectangle.Width);
            Assert.AreEqual(13, rectangle.Height);
        }
        [TestMethod]
        public void ResizeOnSouthBy4DecreasesRectangleHeightBy4()
        {
            Rectangle rectangle = new Rectangle(4, 5, 20, 10);
            rectangle.Resize(ResizeDirection.South, 0, 4);
            Assert.AreEqual(4, rectangle.LeftUpper.X);
            Assert.AreEqual(5, rectangle.LeftUpper.Y);
            Assert.AreEqual(20, rectangle.Width);
            Assert.AreEqual(6, rectangle.Height);
        }
        [TestMethod]
        public void ResizeOnNorthWestBy5x3DecreasesRectangleWidthBy5IncreasesRectangleHeightBy3AndMovesLeftUpperTo9By8()
        {
            Rectangle rectangle = new Rectangle(4, 5, 20, 10);
            rectangle.Resize(ResizeDirection.NorthWest, 5, 3);
            Assert.AreEqual(9, rectangle.LeftUpper.X);
            Assert.AreEqual(8, rectangle.LeftUpper.Y);
            Assert.AreEqual(13, rectangle.Width);
            Assert.AreEqual(15, rectangle.Height);
        }
    }
}