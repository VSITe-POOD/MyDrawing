using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class AddShapeCommand : ICommand
    {
        public AddShapeCommand(Drawing drawing, Shape shape)
        {
            this.drawing = drawing;
            this.shape = shape;
            this.Description = "Add Shape";
        }

        public void Execute()
        {
            drawing.Add(shape);
        }

        public void Undo()
        {
            drawing.Remove(shape);
        }
        private Drawing drawing;
        private Shape shape;

        public string Description { get; private set; }
    }
}
