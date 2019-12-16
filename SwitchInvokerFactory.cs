using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class SwitchInvokerFactory : InvokerFactory
    {
  
        public override BoxInvoker CreateInvoker(Type type)
        {

            switch (type)
            {
                case Type.Taxes:
                    return new TaxesInvoker();
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
        
    }
}
