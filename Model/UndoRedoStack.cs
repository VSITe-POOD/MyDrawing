using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class UndoRedoStack
    {
        public void AddCommand(ICommand command)
        {
            UndoStack.Push(command);
            RedoStack.Clear();
        }

        public void Undo()
        {
            var command = UndoStack.Pop();
            command.Undo();
            RedoStack.Push(command);
        }

        public void Redo()
        {
            var command = RedoStack.Pop();
            command.Execute();
            UndoStack.Push(command);
        }

        public IEnumerable<string> UndoCommands
        {
            get
            {
                List<string> commands = new List<string>();
                foreach(var item in UndoStack)
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
                foreach (var item in RedoStack)
                {
                    commands.Add(item.Description);
                }
                return commands;
            }
        }

        private Stack<ICommand> UndoStack = new Stack<ICommand>();
        private Stack<ICommand> RedoStack = new Stack<ICommand>();
    }
}
