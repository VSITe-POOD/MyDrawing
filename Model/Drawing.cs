using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public class Drawing
    {
        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public int Remove(Shape shape)
        {
            int index = shapes.IndexOf(shape);
            shapes.Remove(shape);
            return index;
        }

        public void Insert(Shape shape, int index)
        {
            shapes.Insert(index, shape);
        }

        public IEnumerable<Shape> Shapes
        {
            get { return shapes; }
        }

        public void Accept(ShapeVisitor visitor)
        {
            foreach (var shape in shapes)
                shape.Accept(visitor);
        }

        private readonly List<Shape> shapes = new List<Shape>();
    }
}
