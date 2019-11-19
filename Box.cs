using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    abstract class Box
    {
        private string name;
        private string display;

        public Box(string name,string display)
        {
            this.name = name;
            this.display = display;
        }
    }
}
