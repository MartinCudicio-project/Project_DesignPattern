﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class gare_station : Box
    {
        private int buying_prize;
        private int mortgage;
        private Player owner;

        public gare_station(int buying_prize,int mortgage, string name,string display) : base (name,display)
        {
            this.Buying_prize = buying_prize;
            this.Mortgage = mortgage;
            this.Owner = null;
        }

        public int Buying_prize { get => buying_prize; set => buying_prize = value; }
        public int Mortgage { get => mortgage; set => mortgage = value; }
        internal Player Owner { get => owner; set => owner = value; }

    }
}
