﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Rock
    {
        public string Name;
        public Rock(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return (String.Format(Name));
        }
    }
}
