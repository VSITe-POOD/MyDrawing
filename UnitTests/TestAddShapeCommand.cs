﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestAddShapeCommand
    {
        [TestMethod]
        public void ExecuteAddsShapeToDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            AddShapeCommand shapeCommand = new AddShapeCommand(drawing, rect);
            shapeCommand.Execute();
            Assert.AreEqual(1, drawing.Shapes.Count());
            Assert.IsTrue(drawing.Shapes.ElementAt(0) == rect);

        }


        [TestMethod]
        public void UndoRemovesShapeFromDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            AddShapeCommand shapeCommand = new AddShapeCommand(drawing, rect);
            shapeCommand.Execute();
            shapeCommand.Undo();
            Assert.AreEqual(0, drawing.Shapes.Count());

        }

        [TestMethod]
        public void SecondExecuteAfterUndoAddsShapeToDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            AddShapeCommand shapeCommand = new AddShapeCommand(drawing, rect);
            shapeCommand.Execute();
            shapeCommand.Undo();
            shapeCommand.Execute();
            Assert.AreEqual(1, drawing.Shapes.Count());

        }
    }
}