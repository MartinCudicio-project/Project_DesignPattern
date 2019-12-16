using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    abstract class InvokerFactory
    {
       
        public enum Type { Taxes, Others, Property, Event, Gare, Public };

        public abstract BoxInvoker CreateInvoker();
        
    }
}
