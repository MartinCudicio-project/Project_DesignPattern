using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Public_utility_Command : BoxCommand
    {
        private Player player;
        private Box box_util;

        public Public_utility_Command(Player player,Box box)
        {
            this.box_util = box;
            this.player = player;

        }

        public void Execute()
        {
            if(this.box_util is Public_utility)
            {
                Public_utility public_util  = (Public_utility)box_util;
                int compteur = 0;
                foreach(Box p in this.player.Property_list)
                {
                    if(p is Public_utility)
                    {
                        compteur++;
                    }
                }
               // 4 et 10
                //if(public_util.Owner)

                
            }
        }
    }
}
