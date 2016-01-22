using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Compare : SinglePlayer
    {
        Scissors scissors = new Scissors("Scissors");
        Rock rock = new Rock("Rock");
        Paper paper = new Paper("Paper");

        string dots = "*****************************************"; 
        string rockScissors = "****  Rock Wins !!!! ...... Rock beats Scissors";
        string scissorsPaper = "****  Scissors Wins!!!! ..... Scissors beats Paper";
        string paperRock = "****  Paper Wins!!!! ..... Paper beats Rock";
        string draw = " *****  It's a Draw!!!******";
      
     

        internal void RPSWins(string winner)
        {
            Console.WriteLine(dots + "\n" + winner + "\n" + dots); 
        }

        internal void DisplayWins()
        {
        }
        internal void DisplayLoss()
        {
        }
        public void ComparingResults(string playerName)
        {
            Console.WriteLine(dots);
            Console.WriteLine("How many rounds would you like to play");
            int rounds = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i<=rounds; i++)
                switch(UserChoice())
                {
                    case 1:
                        switch (ComputerChoice())
                        {
                            case 1:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chose: Rock", playerName);
                                Console.WriteLine("Computer chose :{0}", rock);
                                RPSWins(draw);
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chose: {1}", playerName, rock);
                                Console.WriteLine("Computer chose :{0}", paper);
                                Console.WriteLine(paperRock+ "\n..{0} Loose!!", playerName);
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chose: {1}", playerName, rock);
                                Console.WriteLine("computer chose : {0}", scissors);
                                Console.WriteLine("Computer Wins..."+"\n"+rockScissors);
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 2:
                        switch (ComputerChoice())
                        {
                            case 1:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chose: {1} ", playerName, paper);
                                Console.WriteLine("Computer chose :{0}", rock);
                                Console.WriteLine(paperRock + "\n..{0} Win !!", playerName);
                                Console.WriteLine(dots);
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chosse: {1}", playerName, paper);
                                Console.WriteLine("Computer choose : {0}", paper);
                                RPSWins(draw);
                                Console.WriteLine(dots);
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chosse: {1}", playerName, paper);
                                Console.WriteLine("computer chose : {0}", scissors);
                                Console.WriteLine(scissorsPaper + "\n..Computer Wins");
                                Console.WriteLine(dots);
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 3:
                        switch (ComputerChoice())
                        {
                            case 1:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chosse: {1}", playerName, scissors);
                                Console.WriteLine("Computer chose : {0}", rock);
                                Console.WriteLine(rockScissors + " \n..Computer Wins");
                                Console.WriteLine(dots);
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chosse: {1}", playerName, scissors);
                                Console.WriteLine("Computer chose : {0}", paper);
                                Console.WriteLine(scissorsPaper + "\n..{0} wins!!", playerName);
                                Console.WriteLine(dots);
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine(dots);
                                Console.WriteLine("{0} chose: {1}", playerName, scissors);
                                Console.WriteLine("computer chose : {0}", scissors);
                                RPSWins(draw);
                                Console.WriteLine(dots);
                                Console.ReadLine();
                                break;
                        }
                        break;

                }

        }
    }
}
