using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class EventCommand : BoxCommand
    {
        private Box box;
        private Player player;

        public EventCommand(Box box, Player player)
        {
            this.player = player;
            this.box = box;
        }

        public void Execute()
        {
            if (this.box is Event)
            {
                Event others_box = (Event)this.box;
                string description = others_box.Name;

                Random rand = new Random();                    // Sinon on obtient toujours les mêmes nombres (si on cree un nouveau random a chaque fois)
                DiceInvoker diceinvoker = new DiceInvoker();
                
                switch (description)
                {
                    case "Chance":
                        Command command = new EventDice(this.player, rand,true);
                        diceinvoker.LaunchDice(command);
                        diceinvoker.ExecuteCommand();

                        break;
                    case "Caisse de Communauté":
                        Command command_commu = new EventDice(this.player, rand,false);
                        diceinvoker.LaunchDice(command_commu);
                        diceinvoker.ExecuteCommand();
                        break;
                }
            }
        }
    }
}
