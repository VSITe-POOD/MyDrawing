using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Selection : IMoveable, IResizeable
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
        public void Resize(ResizeDirection direction, double dx, double dy)
        {
            foreach (Shape shape in selectedShapes)
            {
                shape.Resize(direction, dx, dy);
            }
        }
        public IEnumerable<Shape> Shapes
        {
            get { return selectedShapes; }
        }
        private List<Shape> selectedShapes = new List<Shape>();
    }
}
