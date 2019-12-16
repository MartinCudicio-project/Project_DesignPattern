using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Invoker: BoxInvoker
    {
        private BoxCommand taxes_command;
        public void setcommand(BoxCommand command)
        {
            this.taxes_command = command;
        }
        public void ExecuteCommand()
        {
            this.taxes_command.Execute();
        }
    }
}

