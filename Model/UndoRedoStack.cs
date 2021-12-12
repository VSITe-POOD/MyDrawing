using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class UndoRedoStack
    {
        private Stack<ICommand> UndoStack = new Stack<ICommand>();
        private Stack<ICommand> RedoStack = new Stack<ICommand>();
    }
}
