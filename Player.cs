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
        private List<Box> property_list;
        private string image;
        private List<Card> card_list;
        private int index;
        private int _double;

        public Player(string pseudo,string image)
        {
            this.Pseudo = pseudo;
            this.Balance = 1500;
            this.Property_list = new List<Box>();
            this.Image = image;
            this.Card_list = new List<Card>();
            this.index = 0;
        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public int Balance { get => balance; set => balance = value; }
        public string Image { get => image; set => image = value; }
        public int Index { get => index; set => index = value; }
        public int Double { get => _double; set => _double = value; }
        internal List<Box> Property_list { get => property_list; set => property_list = value; }
        internal List<Card> Card_list { get => card_list; set => card_list = value; }
    }
}
