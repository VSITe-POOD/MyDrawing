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
    public class TestEllipse
    {
        [TestMethod]
        public void MoveDisplacesEllipseBy2and5()
        {
            Ellipse ell = new Ellipse(4, 5, 20, 15);
            ell.Move(2, 5);
            Assert.AreEqual(6, ell.Center.X);
            Assert.AreEqual(10, ell.Center.Y);
            Assert.AreEqual(20, ell.SemiAxisA);
            Assert.AreEqual(15, ell.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnEastBy2IncreasesEllipsesWidthBy2()
        {
            Ellipse ell = new Ellipse(4, 5, 20, 15);
            ell.Resize(ResizeDirection.East, 2, 0);
            Assert.AreEqual(22, ell.SemiAxisA);
            Assert.AreEqual(4, ell.Center.X);
            Assert.AreEqual(5, ell.Center.Y);
            Assert.AreEqual(15, ell.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnWestBy2DecreasesEllipsesWidthBy2AndMovesLeftUpperXBy2()
        {
            Ellipse ell = new Ellipse(4, 5, 20, 15);
            ell.Resize(ResizeDirection.West, 2, 0);
            Assert.AreEqual(18, ell.SemiAxisA);
            Assert.AreEqual(6, ell.Center.X);
            Assert.AreEqual(5, ell.Center.Y);
            Assert.AreEqual(15, ell.SemiAxisB);
        }

        [TestMethod]
        public void ResizeOnNorthBy3IncreasesEllipsesHeightBy3AndMovesLeftUpperYBy3()
        {
            Ellipse ell = new Ellipse(4, 5, 20, 15);
            ell.Resize(ResizeDirection.North, 0, 3);
            Assert.AreEqual(4, ell.Center.X);
            Assert.AreEqual(8, ell.Center.Y);
            Assert.AreEqual(18, ell.SemiAxisB);
            Assert.AreEqual(20, ell.SemiAxisA);
        }

        [TestMethod]
        public void ResizeOnSouthBy4DecreasesEllipsesHeightBy4()
        {
            Ellipse ell = new Ellipse(4, 5, 20, 15);
            ell.Resize(ResizeDirection.South, 0, 4);
            Assert.AreEqual(4, ell.Center.X);
            Assert.AreEqual(5, ell.Center.Y);
            Assert.AreEqual(11, ell.SemiAxisB);
            Assert.AreEqual(20, ell.SemiAxisA);
        }

        [TestMethod]
        public void ResizeOnNorthWesBy5x3DecreasesEllipsesWidthBy5IncreasesHeightBy3AndMovesLeftUpperTo9x8()
        {
            Ellipse ell = new Ellipse(4, 5, 20, 15);
            ell.Resize(ResizeDirection.NorthWest, 5, 3);
            Assert.AreEqual(9, ell.Center.X);
            Assert.AreEqual(8, ell.Center.Y);
            Assert.AreEqual(18, ell.SemiAxisB);
            Assert.AreEqual(15, ell.SemiAxisA);
        }
    }
}
