using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Pood.MyDrawing.Model
{
    [TestClass]
    public class TestRectangle
    {
        [TestMethod]
        public void MoveMethodDisplacesRectangleBy2And5()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 10);
            rect.Move(2, 5);
            Assert.AreEqual(rect.LeftUpper.X, 6);
            Assert.AreEqual(rect.LeftUpper.Y, 10);
            Assert.AreEqual(rect.Width, 20);
            Assert.AreEqual(rect.Height, 10);
        }

        [TestMethod]
        public void ResizeOnEastBy2IncreasesRectangleWidthBy2()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 10);
            rect.Resize(ResizeDirection.East, 2, 5);
            Assert.AreEqual(rect.LeftUpper.X, 4);
            Assert.AreEqual(rect.LeftUpper.Y, 5);
            Assert.AreEqual(rect.Width, 22);
            Assert.AreEqual(rect.Height, 10);
        }

        [TestMethod]
        public void ResizeOnWestBy2DecreasesRectangleWidthBy2()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 10);
            rect.Resize(ResizeDirection.West, 2, 0);
            Assert.AreEqual(rect.LeftUpper.X, 6);
            Assert.AreEqual(rect.LeftUpper.Y, 5);
            Assert.AreEqual(rect.Width, 18);
            Assert.AreEqual(rect.Height, 10);
        }

        [TestMethod]
        public void ResizeOnEastBy2IncresesRectangleWidthBy2AndMovesLeftUpperXBy2()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 10);
            rect.Resize(ResizeDirection.East, 2, 0);
            Assert.AreEqual(rect.LeftUpper.X, 4);
            Assert.AreEqual(rect.LeftUpper.Y, 5);
            Assert.AreEqual(rect.Width, 22);
            Assert.AreEqual(rect.Height, 10);
        }

        [TestMethod]
        public void ResizeOnNorthBy3IncreasesRectangleHeightBy3AndMovesLeftUpperYBy3()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 10);
            rect.Resize(ResizeDirection.North, 0, 3);
            Assert.AreEqual(rect.LeftUpper.X, 4);
            Assert.AreEqual(rect.LeftUpper.Y, 8);
            Assert.AreEqual(rect.Width, 20);
            Assert.AreEqual(rect.Height, 13);
        }

        [TestMethod]
        public void ResizeOnSouthBy4DecreasesRectangleHeightBy4AndMovesLeftUpperYBy4()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 10);
            rect.Resize(ResizeDirection.South, 0, 4);
            Assert.AreEqual(rect.LeftUpper.X, 4);
            Assert.AreEqual(rect.LeftUpper.Y, 5);
            Assert.AreEqual(rect.Width, 20);
            Assert.AreEqual(rect.Height, 6);
        }

        [TestMethod]
        public void ResizeOnNorthWestBy5x3DecreasesRectangleWidthBy5IncreasingHeightBy3AndMovesLeftUpperYBy3()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 10);
            rect.Resize(ResizeDirection.NorthWest, 5, 3);
            Assert.AreEqual(rect.LeftUpper.X, 9);
            Assert.AreEqual(rect.LeftUpper.Y, 8);
            Assert.AreEqual(rect.Width, 15);
            Assert.AreEqual(rect.Height, 13);
        }

        [TestMethod]
        public void IsHitReturnsTrueForAPointInsideRectangle()
        {
            Rectangle rect = new Rectangle(1, 1, 6, 6);
            double x = 5;
            double y = -1;
            Assert.IsTrue(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointAboveRectangle()
        {
            Rectangle rect = new Rectangle(1, 1, 6, 6);
            double x = 5;
            double y = 20;
            Assert.IsFalse(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointLeftOfRectangle()
        {
            Rectangle rect = new Rectangle(1, 1, 6, 6);
            double x = 0;
            double y = 6;
            Assert.IsFalse(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointRightOfRectangle()
        {
            Rectangle rect = new Rectangle(1, 1, 6, 6);
            double x = 12;
            double y = 6;
            Assert.IsFalse(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointBelowRectangle()
        {
            Rectangle rect = new Rectangle(1, 1, 6, 6);
            double x = 2;
            double y = -20;
            Assert.IsFalse(rect.IsHit(x, y));
        }
    }
}
