using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RockPaperScissor
{
    interface IPlayersGames
    {
        string PlayerName1();
        string PlayerName2();
        void RPSGame();
        void RPSLSGame();

    }
   public  class PlayersEntry
    {
        public string PlayerName1()
        {
            Console.WriteLine(" **** Player 1 Please Enter Your Name:  ");
            string playerName1 = Console.ReadLine().ToUpper();
            return playerName1;
        }
        public string PlayerName2()
        {
            Console.WriteLine(" **** Player 2 Please Enter Your Name:  ");
            string playerName2 = Console.ReadLine().ToUpper();
            return playerName2;
        }
        public int GameChoiceScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("************************************************\n" +
                              "**************** Make a Selection  : ***********\n" +
                              "************************************************\n" +
                              "************************************************\n" +
                              "**************** 1 : Rock Paper Scissor ********\n" +
                              "**************** 2 : RPS Spock Lizard **********\n" +
                              "************************************************\n" +
                              "***********************************************");
            int gameChoises = int.Parse(Console.ReadLine());
            return gameChoises;
           
        }
        public int PlayerChoiceScreen()
        { 
            Console.Clear();

            Console.WriteLine("************************************************\n" +
                              "**************** Make a Selection  :  *********\n" +
                              "************************************************\n" +
                              "************************************************\n" +
                              "**************** 1 : One player       **********\n" +
                              "**************** 2 : Two Players      **********\n" +
                              "************************************************\n" +
                              "***********************************************");
            int playerChoises = int.Parse(Console.ReadLine());
            return playerChoises;
            

        }
    }
}
