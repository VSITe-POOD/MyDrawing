﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vsite.Pood.MyDrawing.Model;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class TestSelection
    {
        [TestMethod]
        public void BoundingRectangleForEmptySelectionIsEmptyRectangle()
        {
            Selection sel = new Selection();
            Assert.IsTrue(sel.BoundingRectangle == RectangleF.Empty);

        }
        [TestMethod]
        public void BoundingRectangleForSelectionWithSingleShapeIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Vsite.Pood.MyDrawing.Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Assert.IsTrue(sel.BoundingRectangle == rect.BoundingRectangle);
        }
        [TestMethod]
        public void BoundingRectangleForSelectionWithTwoDisplacedShapesIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Vsite.Pood.MyDrawing.Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Shape ellipse = new Vsite.Pood.MyDrawing.Model.Ellipse(200, 100, 100, 50);
            sel.Add(ellipse);
            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10, 20, 290, 130));
        }
        [TestMethod]
        public void BoundingRectangleForSelectionWithTwoOverlappingShapesIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Vsite.Pood.MyDrawing.Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Shape ellipse = new Vsite.Pood.MyDrawing.Model.Ellipse(50, 50, 100, 50);
            sel.Add(ellipse);
            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10, 20, 140, 80));
        }
    }
}
