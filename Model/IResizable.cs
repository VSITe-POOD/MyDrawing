﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public enum ResizeDirection
    {
        North,
        NortEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West,
        NorthWest
    }
    public interface IResizable
    {
        void Resize(ResizeDirection direction, float dx, float dy);
    }
}