using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Dice : Command
    {
        private Player player;
        private Random rand;
        private int dice1;
        private int dice2;
        private int _double;

        public Dice(Player player,Random rand)   // player is the receiver
        {
            this.dice1 = 0;
            this.dice2 = 0;
            this.player = player;
            this.rand = rand;
        }

        public void Execute()
        {
            this.dice1 = rand.Next(1,6);
            this.dice2 = rand.Next(1,6);
            if (dice1 == dice2)
            {
                this.player.Double++;
            }
            else
            {
                this.player.Double = 0;
            }
            int resultat = dice1 + dice2;
            string[] texte = { "Lancer les dées","Regarder votre solde" };
            int choix = Menu.Selection_sans_Consigne(texte);
            if(choix == 1)
            {
                Console.WriteLine("Solde de " + this.player.Pseudo + "a " + this.player.Balance + "euros");
            }
            Console.WriteLine("Lancées des dées du joueur "+player.Pseudo+ "\nResultats : " + dice1 + " + " + dice2 + " = " + resultat);
            if (this.player.Double == 3)
            {
                player.Emprisoned = true;
                player.Index = 10;
                Console.WriteLine(player.Pseudo + " est emprisoné");
                player.Double = 0;
            }
            else
            {
                if((player.Index + dice1 + dice2) < 40)
                {
                    player.Index += dice1 + dice2;
                }
                else
                {
                    player.Index = (dice1 + dice2) - (40 - player.Index);
                    Console.WriteLine("Vous passez par la cas edépart recevez 200 euros");
                    this.player.Balance += 200;
                }

             }
            
        
        }
    }

    class EmprisonedDice : Command
    {
        private Player player;
        private Random rand;
        private int dice1;
        private int dice2;
        private int _double;

        public EmprisonedDice(Player player, Random rand)   // player is the receiver
        {
            this.dice1 = 0;
            this.dice2 = 0;
            this.player = player;
            this.rand = rand;
        }

        public void Execute()
        {
            this.dice1 = rand.Next(1,6);
            this.dice2 = rand.Next(1,6);
            int resultat = dice1 + dice2;
            Console.WriteLine("Lancées des dées du joueur " + player.Pseudo + "\nResultats : " + dice1 + " + " + dice2 + " = " + resultat); 
            if (dice1 == dice2)
            {
                Console.WriteLine(player.Pseudo + " est libre");
                player.Emprisoned = false;
                this.player.Double = 0;
            }
            else
            {
                this.player.Double++;
                Console.WriteLine("Pas de double vous restez en prison\nNombres de tours présents en prison = " + this.player.Double);
            }
            if(this.player.Double == 3)
            {
                Console.WriteLine("Vous sortez après 3 tours passées en prison sans obtenir de double");
                this.player.Emprisoned = false;
                this.player.Double = 0;
            }


        }
    }

    class EventDice : Command
    {
        private Player player;
        private Random rand;
        private int dice1;
        private int dice2;
        private bool chance;

        public EventDice(Player player, Random rand,bool chance)   // player is the receiver
        {
            this.dice1 = 0;
            this.dice2 = 0;
            this.player = player;
            this.rand = rand;
            this.chance = chance;
        }

        public void Execute()
        {
            this.dice1 = rand.Next(1,6);
            this.dice2 = rand.Next(1,6);
            int resultat = dice1 + dice2;
            Console.WriteLine("Lancées des dées du joueur pour la case event " + player.Pseudo + "\nResultats : " + dice1 + " + " + dice2 + " = " + resultat);
            if(this.chance == true)
            {
                Console.WriteLine("Chance : vous gagnez 10 fois votre lancée :" + (10 * resultat));
                this.player.Balance += 10 * resultat;
            }
            else
            {
                Console.WriteLine("Communaute : vous perdez 10 fois votre lancée :" + (10 * resultat));
                this.player.Balance -= 10 * resultat;
            }

        }
    }
    
    class DiceInvoker
    {
        private Command _DiceCommand;
        public void LaunchDice(Command command)  //Compare to setcommand
        {
            this._DiceCommand = command;
        }



        public void ExecuteCommand()
        {
            this._DiceCommand.Execute();
        }
    }

}
