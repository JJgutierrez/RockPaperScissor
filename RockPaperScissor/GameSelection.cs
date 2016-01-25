using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class GameSelection: PlayerChoice
    {
        public void Game()
        {
            string computer = "Computer";

            PlayersEntry pe = new PlayersEntry();
            int o1 = pe.GameChoiceScreen();
            int o2 = pe.PlayerChoiceScreen();
            RPSGame rps = new RPSGame();
            RPSLSGame rpsls = new RPSLSGame();
            PlayerChoice gh = new PlayerChoice();



            switch (o1)
            {
                case 1:
                    switch (o2)
                    {
                        case 1:
                            {
                                string playerName1 = pe.PlayerName1();
                                Console.Write("How many rounds would you like to play.....");
                                int rounds = int.Parse(Console.ReadLine());
                                rps.RPSLogic(playerName1, computer, gh.ComputerChoiceRPS(), rounds);
                            }
                            break;
                        case 2:
                            {
                                string playerName1 = pe.PlayerName1();
                                string playerName2 = pe.PlayerName2();
                                Console.Write("How many rounds would you like to play.....");
                                int rounds = int.Parse(Console.ReadLine());
                                rps.RPSLogic(playerName1, playerName2, gh.UserChoiceRPS(playerName2), rounds);
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (o2)
                    {
                        case 1:
                            {
                                string playerName1 = pe.PlayerName1();
                                Console.Write("How many rounds would you like to play.....");
                                int rounds = int.Parse(Console.ReadLine());
                                rpsls.RPSLSLogic(playerName1, computer, gh.ComputerChoiceRPSLS(), rounds);
                 
                            }
                            break;
                        case 2:
                            {
                                string playerName1 = pe.PlayerName1();
                                string playerNmae2 = pe.PlayerName2();
                                Console.Write("How many rounds would you like to play.....");
                                int rounds = int.Parse(Console.ReadLine());
                                rpsls.RPSLSLogic(playerName1,playerNmae2, gh.UserChoiceRPSLS(playerNmae2), rounds);
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
