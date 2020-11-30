﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsite.pood.MyDrawing.Model
{
    public enum ResizeDirection
    {
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        NorthWest
    }
    public interface IResizeable
    {
        void Resize(ResizeDirection diretion, float dx, float dy);
    }
}