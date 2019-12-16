using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    public interface BoxCommand
    {
        void Execute();
    }

    public interface BoxInvoker
    {
        void setcommand(BoxCommand command);
        void ExecuteCommand();
    }
}
