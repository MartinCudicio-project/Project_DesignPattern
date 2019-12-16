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
                if(public_util.Owner == null)
                {
                    string cout = "" + public_util.Buying_prize;
                    string solde = "" + player.Balance;
                    string[] texte = { "Voulez vous achetez ? Cout : " + cout + "\nVotre solde est de " + solde, "Oui", "Non" };
                    int choix = Menu.Selection_avec_Consigne(texte);

                    if (choix == 0)
                    {
                        public_util.Owner = player;
                        player.Property_list.Add(public_util);
                        player.Balance -= public_util.Buying_prize;
                        Console.WriteLine(player.Pseudo + " a acheté la propriete : " + public_util.Name + " pour " + public_util.Buying_prize + " euros");
                    }
                }
                else
                {
                    if(player != public_util.Owner)
                    {
                        int rent = public_util.Rent;
                        if (compteur == 2)
                        {
                            rent = 7;
                        }
                        public_util.Owner.Balance += rent;
                        player.Balance -= rent;
                        Console.WriteLine(player.Pseudo + " a payé " + rent + " a " + public_util.Owner.Pseudo);

                    }
                } 
            }
        }
    }
}
