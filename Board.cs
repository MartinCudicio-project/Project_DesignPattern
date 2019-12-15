using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Board
    {
        private Box[] boxes;
        private int common_pot;
        private Player[] player_list;

        public Board(Box[] boxes, int common_pot, Player[] player_list)
        {
            this.Boxes = boxes;
            this.Common_pot = common_pot;
            this.Player_list = player_list;
        }

        public int Common_pot { get => common_pot; set => common_pot = value; }
        public Box[] Boxes { get => boxes; set => boxes = value; }
        public Player[] Player_list { get => player_list; set => player_list = value; }


        public void create_player()
        {
            Console.WriteLine("Select how many player you want");
            int choix = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<choix;i++)
            {
                Console.WriteLine("Joueur"+i+" entrez votre nom");
                string nom = Console.ReadLine();
                Console.WriteLine("Select a caracter");
                string car = Console.ReadLine();
                Player player = new Player(nom, car);
                player_list[i] = player;
            }
        }

    }
}
