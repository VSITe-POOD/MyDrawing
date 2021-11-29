﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestAddShapeCommand
    {
        [TestMethod]
        public void ExecuteAddShapeToDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            var command = new AddShapeCommand(drawing, rect);
            command.Execute();
            Assert.AreEqual(1, drawing.Shapes.Count());
            Assert.IsTrue(drawing.Shapes.ElementAt(0) == rect);
        }

        [TestMethod]
        public void UndoRemoveShapeFromDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            var command = new AddShapeCommand(drawing, rect);
            command.Undo();
            Assert.AreEqual(0, drawing.Shapes.Count());
        }

        [TestMethod]
        public void ExecuteAfterUndoRestoresShapeInDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            var command = new AddShapeCommand(drawing, rect);
            command.Undo();

            command.Execute();
            Assert.AreEqual(1, drawing.Shapes.Count());
            Assert.IsTrue(drawing.Shapes.ElementAt(0) == rect);
        }
    }
}
