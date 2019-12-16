using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class SwitchInvokerFactory : InvokerFactory         // On a pas besoin de factory pour les invoker puisque toutes nos commandes sont de la même famille
    {
  
        public override BoxInvoker CreateInvoker()
        {
            return new Invoker();
        }
        
    }
}
