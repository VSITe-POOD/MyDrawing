﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Selection : iMovable, iResizable
    {
        private readonly List<Shape> shapes = new List<Shape>();
        
        public void Add(Shape shape)
        {
            if (shapes.Contains(shape))
                return;
            shapes.Add(shape);
        }

        public void Move(float dx, float dy)
        {
            foreach (Shape shape in shapes)
                shape.Move(dx, dy);
        }

        public void Resize(ResizeDirection direction, float dx, float dy)
        {
            foreach (Shape shape in shapes)
                shape.Move(dx, dy);
        }
    }

    public void Remove(Shape shape)
    {
        shapes.Remove(shape);
    }

    public void Clear()
    {
        shapes.Clear();
    }
}
