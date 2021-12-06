using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    class ResizeSelectedShapesCommand : ICommand
    {
        public ResizeSelectedShapesCommand(Selection selection, ResizeDirection RD, double dx, double dy)
        {
            this.selection = selection;
            this.RD = RD;
            this.dx = dx;
            this.dy = dy;
        }

        public string Description => "Resize Shapes";

        public void Execute()
        {
            selection.Resize(RD, dx, dy);
        }

        public void Undo()
        {
            selection.Resize(RD, -dx, -dy);
        }

        private Selection selection;
        private ResizeDirection RD;
        private double dx;
        private double dy;

    }
}
