using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class PropertyCommand : BoxCommand
    {

        private Box box;
        private Player player;

        public PropertyCommand(Player player, Box box)
        {
            this.box = box;
            this.player = player;
        }

        public void Execute()
        {
            if(box is Property)
            {
                Property property = (Property)box;
                if(property.Owner == null)
                {                  
                    string cout = ""+property.Buying_prize;
                    string solde = "" + player.Balance;
                    string[] texte = { "Voulez vous achetez ? Cout : "+cout+"\nVotre solde est de "+solde, "Oui", "Non" };
                    int choix = Menu.Selection_avec_Consigne(texte);

                    if(choix==0)
                    {
                        property.Owner = player;
                        player.Property_list.Add(property);
                        player.Balance -= property.Buying_prize;
                        Console.WriteLine(player.Pseudo + " a acheté la propriete : " + property.Name + " pour " + property.Buying_prize+" euros") ;
                    }
                }
                else
                {
                    int rent = property.Rents[property.House_number];
                    if(player.Balance > rent)
                    {
                        property.Owner.Balance += rent;
                        player.Balance -= rent;
                        Console.WriteLine(player.Pseudo + " a payé " + rent + " a " + property.Owner.Pseudo);
                    }
                }
            }
        }
    }

   
}
