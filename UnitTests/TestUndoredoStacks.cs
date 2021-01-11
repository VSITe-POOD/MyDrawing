﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.POOD.MyDrowing.Controller;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.UnitTests
{
    [TestClass]
	public class TestUndoRedoStacks
	{
		[TestMethod]
		public void UndoAndRedoMoveCommandsBetweenUndoAndRedoStack()
		{
			UndoRedoStacks stack = new UndoRedoStacks();
			Drawing drawing = new Drawing();
			Shape shape = new Rectangle(10, 20, 30, 40);
			ICommand command = new AddShapeCommand(drawing, shape);
			command.Execute();
			stack.Add(command);
			Assert.IsTrue(stack.CanUndo());
			Assert.IsFalse(stack.CanRedo());
			stack.Undo();
			Assert.IsTrue(stack.CanRedo());
			Assert.IsFalse(stack.CanUndo());
			stack.Redo();
			Assert.IsTrue(stack.CanUndo());
			Assert.IsFalse(stack.CanRedo());
		}

		[TestMethod]
		public void UndoRevertsLastCommandAdded()
		{
			UndoRedoStacks stack = new UndoRedoStacks();
			Drawing drawing = new Drawing();
			Shape shape = new Rectangle(10, 20, 30, 40);
			ICommand command = new AddShapeCommand(drawing, shape);
			command.Execute();
			stack.Add(command);
			Assert.IsTrue(drawing.Shapes.Contains(shape));
			stack.Undo();
			Assert.IsFalse(drawing.Shapes.Contains(shape));
			stack.Redo();
			Assert.IsTrue(drawing.Shapes.Contains(shape));
		}
		[TestMethod]
		public void RedoReappliesCommandUndone()
		{
			UndoRedoStacks stack = new UndoRedoStacks();
			Drawing drawing = new Drawing();
			Shape shape = new Rectangle(10, 20, 30, 40);
			ICommand command = new AddShapeCommand(drawing, shape);
			command.Execute();
			stack.Add(command);
			Assert.IsTrue(drawing.Shapes.Contains(shape));
			stack.Undo();
			Assert.IsFalse(drawing.Shapes.Contains(shape));
			stack.Redo();
			Assert.IsTrue(drawing.Shapes.Contains(shape));
		}

		[TestMethod]
		public void NewCommandClearsRedoStack()
		{
			UndoRedoStacks stack = new UndoRedoStacks();
			Drawing drawing = new Drawing();
			Shape shape = new Rectangle(10, 20, 30, 40);
			ICommand command = new AddShapeCommand(drawing, shape);
			command.Execute();
			stack.Add(command);
			stack.Undo();
			Assert.IsTrue(stack.CanRedo());
			Shape shape2 = new Ellipse(20, 40, 60, 80);
			ICommand command2 = new AddShapeCommand(drawing, shape2);
			command2.Execute();
			stack.Add(command2);
			Assert.IsFalse(stack.CanRedo());
		}



	}
}
