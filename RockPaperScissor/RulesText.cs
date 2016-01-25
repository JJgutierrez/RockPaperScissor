using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class RulesText
    {
        internal string rockLizzard = "Rock crushes Lizard ******";
        internal string lizardSpock = "Lizard poisons Spock ******";
        internal string spockScissors = "Spock smashes Scissors ******";
        internal string scissorsLizard = "Scissors decapitates Lizard ******";
        internal string lizardPaper = "Lizard eats Paper ******";
        internal string paperSpock = "Paper disproves Spock ******";
        internal string spockRock = "Spock vaporizes Rock ******";
        internal string sheldonRockscissors = "(and as it always has) Rock crushes Scissors ******";

        internal string dots = "*****************************************";
        internal string rockScissors = " Rock crushes Scissors ******";
        internal string scissorsPaper = " Scissors cuts Paper ******";
        internal string paperRock = " Paper covers Rock ******";
        internal string draw = " It's a Draw ******";

        public void DisplayDraw()
        {
            Console.WriteLine(dots + "\n**** No winners !\n{0} \n{1} \n{2}", dots, draw, dots);
        }
        internal void DisplayWins(string playerName)
        {
            Console.WriteLine("**** The Winner is  {0} ...! \n{1}\n{2}", playerName);
        }
        internal void DisplayLoss(string playerName2)
        {
            Console.WriteLine(dots + "\n**** Sorry ..Better Luck Next Time... {0} ...!" + "\n" + dots, playerName2);
        }
    }
}
