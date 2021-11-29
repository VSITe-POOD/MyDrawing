using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
