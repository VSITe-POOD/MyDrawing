using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Drawing
    {
        private readonly List<Shape> shapes = new List<Shape>();

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }
        public int Remove(Shape shape)
        {
            int indexOfShape = shapes.IndexOf(shape);
            shapes.Remove(shape);
            return indexOfShape;
        }
        public void Insert(Shape shape, int index)
        {

        }

        public IEnumerable<Shape> Shapes
        {
            get { return this.shapes; }          
        }
    }
}
