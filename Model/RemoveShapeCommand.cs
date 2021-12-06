using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class RemoveShapeCommand : ICommand
    {
        public RemoveShapeCommand(Drawing drawing, Shape shape)
        {
            this.drawing = drawing;
            this.shape = shape;
            Description = "Remove shape";
        }
        public void Execute()
        {
            index = drawing.Remove(shape);
        }

        public void Undo()
        {
            drawing.Insert(shape, index);
        }

        private Drawing drawing;
        private Shape shape;
        private int index;

        public string Description { get; private set; }
    }
}
