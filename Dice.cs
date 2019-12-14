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
            this.dice1 = rand.Next(6);
            this.dice2 = rand.Next(6);
            if (dice1 == dice2)
            {
                this.player.Double += 1;
            }
            int resultat = dice1 + dice2;
            player.Index = dice1 + dice2;
            Console.WriteLine("Lancées des dées du joueur....\nResultats : " + dice1 + " + " + dice2 + " = " + resultat);
        }
    }

    class DiceInvoker
    {
        private Command _DiceCommand;
        public void LaunchDice(Command command)
        {
            this._DiceCommand = command;
        }



        public void ExecuteCommand()
        {
            this._DiceCommand.Execute();
        }
    }

}
