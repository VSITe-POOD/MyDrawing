using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class Selection : IMovable, IResizable
    {
        void AddShape(Shape shape)
        {
            selectedShapes.Add(shape);
        }

        void RemoveShape(Shape shape)
        {
            selectedShapes.Remove(shape);
        }

        void Clear()
        {
            selectedShapes.Clear();
        }

        public void Move(double dx, double dy)
        {
            foreach (Shape shape in selectedShapes)
            {
                shape.Move(dx, dy);
            }
        }

        public void Resize(ResizeDirection RD, double dx, double dy)
        {
            foreach (Shape shape in selectedShapes)
            {
                shape.Resize(RD, dx, dy);
            }
        }

        public IEnumerable<Shape> Shapes
        {
            get { return selectedShapes; }
        }
        private List<Shape> selectedShapes = new List<Shape>();
    }
}
