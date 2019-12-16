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
                case Type.Gare:
                    return new Gare_station_Command(player, main.Board[player.Index]);
                    break;
                case Type.Others:
                    return new Others_Box_Command(main.Board[player.Index],player);
                    break;
                case Type.Event:
                    return new EventCommand(main.Board[player.Index], player);
                    break;
               

                default:
                    throw new NotImplementedException();
            }
        }
    }
}

