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
        public void MoveDisplacesRectangleBy2and5()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 15);
            rect.Move(2, 5);
            Assert.AreEqual(6, rect.LeftUpper.X);
            Assert.AreEqual(10, rect.LeftUpper.Y);
            Assert.AreEqual(20, rect.Width);
            Assert.AreEqual(15, rect.Height);
        }

        [TestMethod]
        public void ResizeOnEastBy2IncreasesRectangleWidthBy2()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 15);
            rect.Resize(ResizeDirection.East, 2, 0);
            Assert.AreEqual(22, rect.Width);
            Assert.AreEqual(4, rect.LeftUpper.X);
            Assert.AreEqual(5, rect.LeftUpper.Y);
            Assert.AreEqual(15, rect.Height);
        }

        [TestMethod]
        public void ResizeOnWestBy2DecreasesRectangleWidthBy2AndMovesLeftUpperXBy2()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 15);
            rect.Resize(ResizeDirection.West, 2, 0);
            Assert.AreEqual(18, rect.Width);
            Assert.AreEqual(6, rect.LeftUpper.X);
            Assert.AreEqual(5, rect.LeftUpper.Y);
            Assert.AreEqual(15, rect.Height);
        }

        [TestMethod]
        public void ResizeOnNorthBy3IncreasesRectangleHeightBy3AndMovesLeftUpperYBy3()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 15);
            rect.Resize(ResizeDirection.North, 0, 3);
            Assert.AreEqual(4, rect.LeftUpper.X);
            Assert.AreEqual(8, rect.LeftUpper.Y);
            Assert.AreEqual(18, rect.Height);
            Assert.AreEqual(20, rect.Width);
        }

        [TestMethod]
        public void ResizeOnSouthBy4DecreasesRectangleHeightBy4()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 15);
            rect.Resize(ResizeDirection.South, 0, 4);
            Assert.AreEqual(4, rect.LeftUpper.X);
            Assert.AreEqual(5, rect.LeftUpper.Y);
            Assert.AreEqual(11, rect.Height);
            Assert.AreEqual(20, rect.Width);
        }

        [TestMethod]
        public void ResizeOnNorthWesBy5x3DecreasesRectangleWidthBy5IncreasesHeightBy3AndMovesLeftUpperTo9x8()
        {
            Rectangle rect = new Rectangle(4, 5, 20, 15);
            rect.Resize(ResizeDirection.NorthWest, 5, 3);
            Assert.AreEqual(9, rect.LeftUpper.X);
            Assert.AreEqual(8, rect.LeftUpper.Y);
            Assert.AreEqual(18, rect.Height);
            Assert.AreEqual(15, rect.Width);
        }

        [TestMethod]
        public void IsHitReturnsTrueForAPointInsadeRectangle()
        {
            double x = 5;
            double y = 6;
            Rectangle rect = new Rectangle(1, 6, 6, 6);

            Assert.IsTrue(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointRightToRectangle()
        {
            double x = 10;
            double y = 6;
            Rectangle rect = new Rectangle(1, 6, 6, 6);

            Assert.IsFalse(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointLeftToRectangle()
        {
            double x = 0;
            double y = 6;
            Rectangle rect = new Rectangle(1, 6, 6, 6);

            Assert.IsFalse(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointAboveRectangle()
        {
            double x = 5;
            double y = 12;
            Rectangle rect = new Rectangle(1, 6, 6, 6);

            Assert.IsFalse(rect.IsHit(x, y));
        }

        [TestMethod]
        public void IsHitReturnsFalseForAPointBelowRectangle()
        {
            double x = 5;
            double y = 0;
            Rectangle rect = new Rectangle(1, 6, 6, 5);

            Assert.IsFalse(rect.IsHit(x, y));
        }
    }
}
