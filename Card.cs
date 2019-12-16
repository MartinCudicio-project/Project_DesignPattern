using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Card
    {
        private string description;

        public Card(string description)
        {
            Description = description;
        }

        public string Description { get => description; set => description = value; }
    }
}
