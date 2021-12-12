using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class UndoRedoStack
    {
        public void AddCommand(ICommand command)
        {
            undoStack.Push(command);
            redoStack.Clear();
        }

        public void Undo()
        {
            var command = undoStack.Pop();
            command.Undo();
            redoStack.Push(command);
        }
        public void Redo()
        {
            var command = redoStack.Pop();
            command.Execute();
            undoStack.Push(command);
        }

        public IEnumerable<string> UndoCommands
        {
            get
            {
                List<string> commands = new List<string>();
                foreach (var item in undoStack)
                {
                    commands.Add(item.Description);
                }
                return commands;
            }
        }
        public IEnumerable<string> RedoCommands
        {
            get
            {
                List<string> commands = new List<string>();
                foreach (var item in redoStack)
                {
                    commands.Add(item.Description);
                }
                return commands;
            }
        }

        private Stack<ICommand> undoStack = new Stack<ICommand>();
        private Stack<ICommand> redoStack = new Stack<ICommand>();
    }
}
