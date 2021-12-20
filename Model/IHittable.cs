using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public interface IHittable
    {
        public bool IsHit(double X, double y);
    }
}
