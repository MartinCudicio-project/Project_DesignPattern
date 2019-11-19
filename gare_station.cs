using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class gare_station : Box
    {
        private int buying_prize;

        public gare_station(int buying_prize, string name,string display) : base (name,display)
        {
            this.buying_prize = buying_prize;
        }
    }
}
