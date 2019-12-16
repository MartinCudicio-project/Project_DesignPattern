using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class TaxesCommand : BoxCommand
    {
        private Box box;
        private int taxes;
        private Player player;

        public TaxesCommand(Player player,Box box)
        {
            this.taxes = 0;
            this.box = box;           
            this.player = player;
        }

        public void Execute()
        {
            if (this.box is Taxes)
            {
                Taxes taxe = (Taxes)box;
                this.taxes = taxe.Taxe;
                player.Balance -= taxes;
                Console.WriteLine(player.Pseudo + " paye " + taxes + " pour la case " + taxes);
                Console.WriteLine("Compte actuel : " + player.Balance);
            }
        }
    }

    class TaxesInvoker : BoxInvoker
    {
        private BoxCommand taxes_command;
        public void setcommand(BoxCommand command)
        {
            this.taxes_command = command;
        }
        public void ExecuteCommand()
        {
            this.taxes_command.Execute();
        }
    }
}
