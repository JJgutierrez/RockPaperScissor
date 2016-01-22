using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        static void Main()
        {
            PlayersEntry name = new PlayersEntry();
            Compare fg = new Compare();
            fg.ComparingResults(name.PlayerName1());
            
        }
    }
}
