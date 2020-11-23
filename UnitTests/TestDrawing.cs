﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using vsite.pood.MyDrawing.Model;

namespace vsite.pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestDrawing
    {
        [TestMethod]
        public void AddMethodAddsRectangleToDrawing()
        {
            Rectangle rect = new Rectangle();
            Drawing drawing = new Drawing();
            drawing.Add(rect);
            Assert.IsTrue(drawing.Shapes.Contains(rect));
        }

        [TestMethod]
        public void AddMethodAddsEllipseToDrawing()
        {
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
        }
        [TestMethod]
        public void AddMethodAddsEllipseAndRectangleToDrawing()
        {
            Ellipse ellipse = new Ellipse();
            Rectangle rect = new Rectangle();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            drawing.Add(rect);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
            Assert.IsTrue(drawing.Shapes.Contains(rect));
        }
        [TestMethod]
        public void RemoveMethodRemovesShapeFromDrawing()
        {
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
            drawing.Remove(ellipse);
            Assert.IsTrue(drawing.Shapes.Count() == 0);
        }

        [TestMethod]
        public void ClearMethodRemovesAllShapesFromDrawing()
        {
            Ellipse ellipse = new Ellipse();
            Rectangle rect = new Rectangle();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            drawing.Add(rect);
            drawing.Clear();
            Assert.IsTrue(drawing.Shapes.Count() == 0);
        }

    }
}