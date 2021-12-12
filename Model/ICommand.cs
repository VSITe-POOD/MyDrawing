using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public interface ICommand
    {
        void Execute();
        void Undo();

        string Description { get;  }

        string Description();
    }
}
