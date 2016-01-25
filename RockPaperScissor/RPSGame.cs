using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissor
{
    class RPSGame : RulesText
    {
        Scissors scissors = new Scissors("Scissors");
        Rock rock = new Rock("Rock");
        Paper paper = new Paper("Paper");

        internal int counterPlayer1 = 0;
        internal int counterPlayer2 = 0;
        internal string path = @"PlayersData.txt";

        public void RPSLogic(string playerN1, string playerN2,int pcOrPlayer2, int rounds)
        {
            PlayerChoice pc = new PlayerChoice();

            Console.WriteLine(dots);
            for (int i = 0; i <= rounds; i++)
                try {
                    switch (pc.UserChoiceRPS(playerN1))
                    {
                        case 1:
                            switch (pcOrPlayer2)
                            {
                                case 1:
                                    DisplayDraw();
                                    Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose :{3}", playerN1, rock, playerN2, rock);
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose :{3} \n**** {4}", playerN1, rock, playerN2, paper, paperRock);
                                    Console.ReadLine();
                                    counterPlayer2++;
                                    break;
                                case 3:
                                    Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3} \n****{4}", playerN1, rock, playerN2, scissors, scissorsPaper);
                                    Console.ReadLine();
                                    counterPlayer1++;
                                    break;
                                default:
                                    Console.WriteLine("No a valid choice");
                                    break;
                            }
                            break;
                        case 2:
                            switch (pcOrPlayer2)
                            {
                                case 1:
                                    Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose :{3} \n****{4}", playerN1, paper, playerN2, rock, paperRock);
                                    Console.ReadLine();
                                    counterPlayer1++;
                                    break;
                                case 2:
                                    DisplayDraw();
                                    Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose :{3}", playerN1, paper, playerN2, paper);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("**** Player{0} chose: {1} \n**** Player2 {2} chose :{3} \n****{4}", playerN1, paper, playerN2, scissors, scissorsPaper);
                                    Console.ReadLine();
                                    counterPlayer2++;
                                    break;
                                default:
                                    Console.WriteLine("No a valid choice");
                                    break;
                            }
                            break;
                        case 3:
                            switch (pcOrPlayer2)
                            {
                                case 1:
                                    Console.WriteLine("***** Player{0} chose: {1} \n**** Player2 {2} chose :{3} \n****{4}", playerN1, scissors, playerN2, rock, rockScissors);
                                    Console.ReadLine();
                                    counterPlayer2++;
                                    break;
                                case 2:
                                    Console.WriteLine("**** Player {0} chose: {1}\n**** Player2 {2} chose : {3} \n****{4}", playerN1, scissors, playerN2, paper, scissorsPaper);
                                    Console.ReadLine();
                                    counterPlayer1++;
                                    break;
                                case 3:
                                    DisplayDraw();
                                    Console.WriteLine("**** Player {0} chose: {1}\n**** Player2 {2} chose :{3}", playerN1, scissors, playerN2, scissors);
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("No a valid choice");
                                    break;

            
                            }
                            break;
                        default:
                            Console.WriteLine("No a valid choice");
                            break;
                    }
                    

                }
                catch { }
            PrintScore(playerN1, playerN2);
        }


        public void PrintScore(string playerNameScore1, string playerNameScore2)
        {
            if (counterPlayer1 >= counterPlayer2)
            {
                DisplayWins(playerNameScore1);
                DisplayLoss(playerNameScore2);
                string winPhraseplayer = DisplayWins(playerNameScore1).ToString();
                string[] appendText = { "{0} with {1}", winPhraseplayer , counterPlayer1.ToString() };
                string appendText2 = appendText.ToString();
                File.AppendAllText(path,appendText2);
            }
            else if (counterPlayer2>= counterPlayer1)
            {
                DisplayWins(playerNameScore2);
                DisplayLoss(playerNameScore1);
                string winPhraseplayer = DisplayWins(playerNameScore2).ToString();
                string[] appendText = { "{0} with {1}", winPhraseplayer, counterPlayer2.ToString() };
                string appendText2 = appendText.ToString();
                File.AppendAllText(path,DisplayWins(playerNameScore2).ToString());
            }
            else
            {
                DisplayDraw();
            }
            
            
           
        }
    }
}
