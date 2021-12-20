using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSite.POOD.MyDrawing.Model
{
    public interface IHittable
    {
        bool IsHit(double x, double y);
    }
}
