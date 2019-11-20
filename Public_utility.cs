using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Public_utility : Box
    {
        private int buying_prize;
        private int rent;

        public Public_utility(int buying_prize,int rent, string name, string display) : base(name, display)
        {
            this.Buying_prize = buying_prize;
            this.Rent = rent;
        }

        public int Buying_prize { get => buying_prize; set => buying_prize = value; }
        public int Rent { get => rent; set => rent = value; }
    }
}
