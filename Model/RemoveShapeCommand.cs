using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class RemoveShapeCommand : ICommand
    {
        private readonly Drawing drawing;
        private readonly Shape shape;
        private int indexOfLastRemoved;
        public string Description { get; private set; }
        public RemoveShapeCommand(Drawing drawing, Shape shape)
        {
            this.drawing = drawing;
            this.shape = shape;
            this.Description = "Remove shape";
        }

        public void Execute()
        {
            drawing.Remove(shape);
        }

        public void Undo()
        {
            drawing.Insert(shape, indexOfLastRemoved);
        }
    }
}
