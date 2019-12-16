using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Property : Box
    {
        private int buying_prize;
        private int mortgage;
        private int house_prize;
        private int[] rents;
        private string color;
        private int house_number;
        private Player owner;

        public Property(int buying_prize, int mortgage, int house_prize, int[] rents, string color, int house_number, Player owner, string name, string display) : base(name, display)
        {
            this.Buying_prize = buying_prize;
            this.Mortgage = mortgage;
            this.House_prize = house_prize;
            this.Rents = rents;
            this.Color = color;
            this.House_number = house_number;
            this.Owner = owner;
        }

        public Player Owner { get => owner; set => owner = value; }
        public int Buying_prize { get => buying_prize; set => buying_prize = value; }
        public int Mortgage { get => mortgage; set => mortgage = value; }
        public int House_prize { get => house_prize; set => house_prize = value; }
        public int[] Rents { get => rents; set => rents = value; }
        public string Color { get => color; set => color = value; }
        public int House_number { get => house_number; set => house_number = value; }

        public override int[] returnvalue()
        {
            int[] data = { this.buying_prize, this.mortgage,this.House_prize };
            return data;
        }

    }
}
