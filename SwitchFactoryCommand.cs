using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class SwitchFactoryCommand : CommandFactory
    {
        public override BoxCommand CreateCommand(Type type, Game main,Player player)
        {
                       
            switch (type)
            {
                case Type.Taxes:
                    return new TaxesCommand(player,main.Board[player.Index]);
                    break;

                case Type.Property:
                    return new PropertyCommand(player, main.Board[player.Index]);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}

