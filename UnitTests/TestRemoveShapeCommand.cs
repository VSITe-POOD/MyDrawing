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
    public class TestRemoveShapeCommand
    {
        [TestMethod]
        public void ExecuteRemovesShapeFromDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            var command = new AddShapeCommand(drawing, rect);

            command.Execute();
            Assert.AreEqual(1, drawing.Shapes.Count());
            Assert.IsTrue(drawing.Shapes.ElementAt(0) == rect);
        }
        [TestMethod]
        public void UndoBringsShapeBackToDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            var command = new AddShapeCommand(drawing, rect);

            command.Execute();

            command.Undo();
            Assert.AreEqual(0, drawing.Shapes.Count());
        }
        [TestMethod]
        public void ExecuteAfterUndoRemovesShapeFromDrawing()
        {
            Drawing drawing = new Drawing();
            var rect = new Rectangle(1, 2, 3, 4);
            var command = new AddShapeCommand(drawing, rect);

            command.Execute();

            command.Undo();

            command.Execute();
            Assert.AreEqual(1, drawing.Shapes.Count());
            Assert.IsTrue(drawing.Shapes.ElementAt(0) == rect);
        }
    }
}
