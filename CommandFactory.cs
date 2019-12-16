using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    public enum Type { Taxes, Others, Property, Event, Gare, Public };
    abstract class CommandFactory
    {
        
        public abstract BoxCommand CreateCommand(Type type,Game main,Player player);
    }
}
