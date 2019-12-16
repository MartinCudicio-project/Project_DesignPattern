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
        private int index;
        private int _double;
        private int number_gare;
        private bool emprisoned;

        public Player(string pseudo,string image)
        {
            this.Pseudo = pseudo;
            this.Balance = 1500;
            this.Property_list = new List<Box>();
            this.Image = image;
            this.index = 0;
            this.number_gare = 0;
            this.Emprisoned = false;

        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public int Balance { get => balance; set => balance = value; }
        public string Image { get => image; set => image = value; }
        public int Index { get => index; set => index = value; }
        public int Double { get => _double; set => _double = value; }
        public int Number_gare { get => number_gare; set => number_gare = value; }
        public bool Emprisoned { get => emprisoned; set => emprisoned = value; }
        internal List<Box> Property_list { get => property_list; set => property_list = value; }
    }
}
