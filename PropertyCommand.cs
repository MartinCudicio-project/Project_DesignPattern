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

        public bool countproperty()
        {
            int compteur = 0;
            bool complete = false;
            List<Box> list_box = player.Property_list;
            ConsoleColor color = ConsoleColor.White;
            foreach (Box p in list_box)
            {
                if (this.box is Property && p is Property)
                {
                    Property list_box_item = (Property)p;
                    Property actual_box = (Property)this.box;
                    if(actual_box.Color == list_box_item.Color)
                    {
                        compteur++;
                    }
                    color = actual_box.Color;
                }
                
            } 
            if(color == ConsoleColor.DarkBlue && compteur == 2)
            {
                complete = true;
            }
            else if(compteur == 3)
            {
                complete = true;
            }

            return complete;
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
                    if (player == property.Owner)
                    {
                        Console.WriteLine("Vous etes chez vous");
                        if (countproperty() == true && property.House_number < 4)
                        {
                            int cout_int = property.House_prize;
                            string cout = "" + property.House_prize;
                            string solde = "" + player.Balance;
                            string[] texte = { "Voulez vous une maison ? Cout : " + cout + "\nVotre solde est de " + solde, "Oui", "Non" };
                            int choix = Menu.Selection_avec_Consigne(texte);
                            string[] texte2 = { "Combien de maison : " + cout + "\nVotre solde est de " + solde, "1", "2","3","4"};
                            int choix2 = Menu.Selection_avec_Consigne(texte2)+1;
                            if(cout_int*choix2 > player.Balance)
                            {
                                Console.WriteLine("Vous n'avez pas l'argent");

                            }
                            else
                            {
                                player.Balance -= cout_int * choix2;
                                Console.WriteLine("Vous avez achetez "+choix2+ " maisons");
                            }

                        }
                    }
                    else
                    {
                        int rent = property.Rents[property.House_number];
                        property.Owner.Balance += rent;
                        player.Balance -= rent;
                        Console.WriteLine(player.Pseudo + " a payé " + rent + " a " + property.Owner.Pseudo);
                    }
                }
            }
        }
    }

   
}
