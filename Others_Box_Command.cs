using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Others_Box_Command : BoxCommand
    {
        private Box box;
        private Player player;

        public Others_Box_Command(Box box,Player player)
        {
            this.player = player;
            this.box = box;
        }

        public void Execute()
        {
            if(this.box is Others_Box)
            {
                Others_Box others_box = (Others_Box)this.box;
                string description = others_box.Name;
                switch(description)
                {
                    case "Case départ":
                        this.player.Balance += 200;
                        Console.WriteLine(this.player.Pseudo + " a gané 200 euros en passant sur la case départ");
                        break;
                    case "Prison":
                        Console.WriteLine("Case prison : Il ne se passe rien ");
                        break;
                    case "Parc gratuit":
                        Console.WriteLine("Case parc gratuit: vous recevez 100 euros");
                        this.player.Balance += 100;
                        break;
                    case "Aller en prison":
                        Console.WriteLine("Case aller en prison : vous allez en prison sans passez par la case départ");
                        this.player.Index = 10;
                        this.player.Emprisoned = true;
                        this.player.Double = 0;
                        break;
                }
            }
        }

    }
}
