using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSite.POOD.MyDrawing.Model;

namespace VSite.POOD.MyDrawing.Model
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
            var rect = new Rectangle(0, 0, 10, 20);
            var command = new AddShapeCommand(drawing, rect);
            undoRedo.AddCommand(command);

            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(1, undoCommands.Count());
            Assert.AreEqual("Add Shape", undoCommands.First());
        }

        [TestMethod]
        public void AddCommandPushesTwoCommandsToUndoStack()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rect = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rect);
            undoRedo.AddCommand(addCommand);

            var removeCommand = new RemoveShapeCommand(drawing, rect);
            undoRedo.AddCommand(removeCommand);

            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(2, undoCommands.Count());
            Assert.AreEqual("Remove Shape", undoCommands.First());
        }

        [TestMethod]
        public void AddCommandPushesTwoCommandsToUndoStackAndUndoRemovesLastCommand()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rect = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rect);
            undoRedo.AddCommand(addCommand);

            var removeCommand = new RemoveShapeCommand(drawing, rect);
            undoRedo.AddCommand(removeCommand);

            undoRedo.Undo();

            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(1, undoCommands.Count());
            Assert.AreEqual("Add Shape", undoCommands.First());

            var redoCommands = undoRedo.RedoCommands;
            Assert.AreEqual(1, redoCommands.Count());
            Assert.AreEqual("Remove Shape", redoCommands.First());

        }

        [TestMethod]
        public void AddCommandPushesTwoCommandsToUndoStackAndRedoAddsLastCommandFromStack()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rect = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rect);
            undoRedo.AddCommand(addCommand);

            var removeCommand = new RemoveShapeCommand(drawing, rect);
            undoRedo.AddCommand(removeCommand);

            undoRedo.Undo();
            undoRedo.Redo();

            var undoCommands = undoRedo.UndoCommands;
            Assert.AreEqual(2, undoCommands.Count());
            Assert.AreEqual("Remove Shape", undoCommands.First());

            var redoCommands = undoRedo.RedoCommands;
            Assert.AreEqual(0, redoCommands.Count());
        }

        [TestMethod]
        public void AddCommandEmptiesRedoStack()
        {
            var undoRedo = new UndoRedoStack();
            Assert.IsTrue(undoRedo.UndoCommands.Count() == 0);
            var drawing = new Drawing();
            var rect = new Rectangle(0, 0, 10, 20);
            var addCommand = new AddShapeCommand(drawing, rect);
            undoRedo.AddCommand(addCommand);

            var removeCommand = new RemoveShapeCommand(drawing, rect);
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
