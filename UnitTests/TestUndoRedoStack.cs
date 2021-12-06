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
    public class TestUndoRedoStack
    {
        [TestMethod]
        public void AddCommandPushesCommandToUndoStack()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rectangle = new Rectangle(0, 0, 10, 20);
            var command = new AddShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(command);
            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(1, undoCommands.Count());
            Assert.AreEqual("Add shape", undoCommands.First());
        }
        [TestMethod]
        public void AddCommandPushesToCommandsToUndoStack()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rectangle = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(addCommand);
            var removeCommand = new RemoveShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(removeCommand);
            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(2, undoCommands.Count());
            Assert.AreEqual("Remove shape", undoCommands.First());
        }
        [TestMethod]
        public void AddCommandPushesTwoCommandsToUndoStackAndUndoRemovesLastCommand()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rectangle = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(addCommand);
            var removeCommand = new RemoveShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(removeCommand);
            undoRedo.Undo();
            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(1, undoCommands.Count());
            Assert.AreEqual("Add shape", undoCommands.First());
            var redoCommands = undoRedo.RedoCommands;
            Assert.AreEqual(1, redoCommands.Count());
            Assert.AreEqual("Remove shape", redoCommands.First());
        }
        [TestMethod]
        public void AddCommandPushesTwoCommandsToUndoStackAndRedoRemovesLastCommandFromUndoStack()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rectangle = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(addCommand);
            var removeCommand = new RemoveShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(removeCommand);
            undoRedo.Undo();
            undoRedo.Redo();
            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(2, undoCommands.Count());
            Assert.AreEqual("Remove shape", undoCommands.First());
            Assert.AreEqual(0, undoRedo.RedoCommands.Count());
        }
        [TestMethod]
        public void AddCommandEmptyRedoStack()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rectangle = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(addCommand);
            var removeCommand = new RemoveShapeCommand(drawing, rectangle);
            undoRedo.AddCommand(removeCommand);
            undoRedo.Undo();
            var redoCommands = undoRedo.RedoCommands;
            Assert.AreEqual(1, redoCommands.Count());
            undoRedo.AddCommand(addCommand);
            redoCommands = undoRedo.RedoCommands;
            Assert.AreEqual(0, redoCommands.Count());
        }
    }
}
