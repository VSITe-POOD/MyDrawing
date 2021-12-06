using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class MoveSelectedShapesCommand : ICommand
    {
        public MoveSelectedShapesCommand(Selection selection, double dx, double dy)
        {
            this.selection = selection;
            this.dx = dx;
            this.dy = dy;
        }

        public string Description { get { return "Move Shapes"; } }

        public void Execute()
        {
            selection.Move(dx, dy);
        }

        public void Undo()
        {
            selection.Move(-dx, -dy);
        }

        private Selection selection;
        double dx;
        double dy;
    }
}
