using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Player
    {
        private string pseudo;
        private int balance;
        private Box[] property_list;
        private string image;
        private Card[] card_list;
        private int index;

        public Player(string pseudo,string image)
        {
            this.Pseudo = pseudo;
            this.Balance = 1500;
            this.Property_list = null;
            this.Image = image;
            this.Card_list = null;
            this.index = 0;
        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public int Balance { get => balance; set => balance = value; }
        public string Image { get => image; set => image = value; }
        public int Index { get => index; set => index = value; }
        internal Box[] Property_list { get => property_list; set => property_list = value; }
        internal Card[] Card_list { get => card_list; set => card_list = value; }
    }
}
