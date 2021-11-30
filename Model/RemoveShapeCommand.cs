using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class RemoveShapeCommand : ICommand
    {
        public RemoveShapeCommand(Drawing drawing, Shape shape)
        {
            this.drawing = drawing;
            this.shape = shape;
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
    }
}
