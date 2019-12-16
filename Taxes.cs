using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Taxes : Box
    {
        private int taxe;

        public Taxes(int taxe, string name, string display) : base(name, display)
        {
            this.Taxe = taxe;
        }
        public int Taxe { get => taxe; set => taxe = value; }

        public override int[] returnvalue()
        {
            int[] data = { this.taxe};
            return data;
        }
    }
}
