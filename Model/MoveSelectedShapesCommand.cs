using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    class MoveSelectedShapesCommand : ICommand
    {
        Selection selection;
        double dx;
        double dy;

        public MoveSelectedShapesCommand(Selection selection, double dx, double dy)
        {
            this.selection = selection;
            this.dx = dx;
            this.dy = dy;
        }
        public string Description
        {
            get { return "Move shapes"; }
        }

        public void Execute()
        {
            selection.Move(dx, dy);
        }

        public void Undo()
        {
            selection.Move(-dx, -dy);
        }
    }
}
