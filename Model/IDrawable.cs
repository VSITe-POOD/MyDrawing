﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsite.pood.MyDrawing.Model
{
    public interface IDrawable
    {
        void Draw(IGraphics graphics);
    }
}