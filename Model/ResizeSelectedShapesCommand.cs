using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    class ResizeSelectedShapesCommand : ICommand
    {
        private ResizeDirection direction;
        private Selection selection;
        private double dx;
        private double dy;

        public ResizeSelectedShapesCommand(Selection selection, ResizeDirection direction, double dx, double dy)
        {
            this.selection = selection;
            this.direction = direction;
            this.dx = dx;
            this.dy = dy;
        }
        public string Description => "Resize shapes";

        public void Execute()
        {
            selection.Resize(direction, dx, dy);
        }

        public void Undo()
        {
            selection.(direction, -dx, -dy);
        }
    }
}
