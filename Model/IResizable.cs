﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    [Flags]
    public enum ResizeDirection
    {
        North = 0x0001,
        East = 0x0002,
        South = 0x0004, 
        West = 0x0008,
        NorthEast = North | East,
        NorthWest = North | West,
        SouthEast = South | East,
        SouthWest = South | West
    }
    public interface IResizable
    {
       public void Resize(ResizeDirection direction, double dx, double dy);
    }
}
