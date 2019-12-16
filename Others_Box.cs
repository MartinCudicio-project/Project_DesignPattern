using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Others_Box: Box
    {
        
        public Others_Box (string name, string display) : base(name, display)
        {
            
        }
        public override int[] returnvalue()
        {
            int[] data = { };
            return data;
        }
    }
}
