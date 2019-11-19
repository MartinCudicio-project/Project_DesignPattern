﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_game
{
    class Event : Box
    {
        private string description;
        
        public Event(string description, string name, string display) : base(name, display)
        {
            this.description = description;
        }
    }
}
