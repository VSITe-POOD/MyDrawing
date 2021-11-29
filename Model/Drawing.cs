using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Drawing
    {
        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void Remove(Shape shape)
        {
            shapes.Remove(shape);
        }

        public IEnumerable<Shape> Shapes { get { return shapes; } }

        private readonly List<Shape> shapes = new List<Shape>();
    }
}
