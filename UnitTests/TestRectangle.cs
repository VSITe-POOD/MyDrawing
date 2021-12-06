﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}