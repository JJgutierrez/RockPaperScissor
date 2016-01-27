﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissor
{
    class RPSLSGame : RulesText
    {
        Scissors scissors = new Scissors("Scissors");
        Rock rock = new Rock("Rock");
        Paper paper = new Paper("Paper");
        string lizard = "Lizard";
        string spock = "Spock";
        int counterPlayer1 = 0;
        int counterPlayer2 = 0;
        string path = @"PlayersData.txt";

        public void RPSLSLogic(string playerN1, string playerN2, int pcOrPlayer2, int rounds)
        {
            Console.WriteLine(dots);
            PlayerChoice pc = new PlayerChoice();

            for (int i = 0; i <= rounds; i++)
                switch (pc.UserChoiceRPSLS(playerN1))
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
                            case 4:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3} \n****{4}", playerN1, rock, playerN2, lizard, rockLizzard);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            case 5:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3} \n****{4}", playerN1, rock, playerN2, spock, spockRock);
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
                            case 4:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3}\n****{4}", playerN1, paper, playerN2, lizard, lizardPaper);
                                Console.ReadLine();
                                counterPlayer2++;
                                break;
                            case 5:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3}\n****{4}", playerN1, paper, playerN2, spock, paperSpock);
                                Console.ReadLine();
                                counterPlayer1++;
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
                                Console.WriteLine("**** Player{0} chose: {1} \n**** Player2 {2} chose : {3} \n****{4}", playerN1, scissors, playerN2, rock, rockScissors);
                                Console.ReadLine();
                                counterPlayer2++;
                                break;
                            case 2:
                                Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose : {3} \n****{4}", playerN1, scissors, playerN2, paper, scissorsPaper);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            case 3:
                                DisplayDraw();
                                Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose : {3}", playerN1, scissors, playerN2, scissors);
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3} \n**** {4}", playerN1, scissors, playerN2, lizard, scissorsLizard);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            case 5:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3} \n**** {4}", playerN1, scissors, playerN2, spock, spockScissors);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            default:
                                Console.WriteLine("No a valid choice");
                                break;
                        }
                        break;
                    case 4:
                        switch (pcOrPlayer2)
                        {
                            case 1:
                                Console.WriteLine("**** Player{0} chose: {1} \n**** Player2 {2} chose : {3}  \n****{4}", playerN1, lizard, playerN2, rock, rockLizzard);
                                Console.ReadLine();
                                counterPlayer2++;
                                break;
                            case 2:
                                Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose : {3}  \n****{4}", playerN1, lizard, playerN2, paper, lizardPaper);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            case 3:
                                Console.WriteLine("**** Player {0} chose: {1} \n**** Player2 {2} chose : {3}  \n****{4}", playerN1, lizard, playerN2, scissors, scissorsLizard);
                                Console.ReadLine();
                                break;
                            case 4:
                                DisplayDraw();
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3}", playerN1, lizard, playerN2, lizard);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            case 5:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3}  \n****{4}", playerN1, lizard, playerN2, spock, lizardSpock);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            default:
                                Console.WriteLine("No a valid choice");
                                break;
                        }
                        break;
                    case 5:
                        switch (pcOrPlayer2)
                        {
                            case 1:
                                Console.WriteLine("**** Player{0} chose: {1} \n**** Player2 {2} chose :{3}  \n****{4}", playerN1, spock, playerN2, rock, spockRock);
                                Console.ReadLine();
                                counterPlayer2++;
                                break;
                            case 2:
                                Console.WriteLine("**** Player {0} chose: {1}\n**** Player2 {2} chose : {3}  \n****{4}", playerN1, spock, playerN2, paper, paperSpock);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            case 3:
                                Console.WriteLine("**** Player {0} chose: {1}\n**** Player2 {2} chose :{3}  \n****{4}", playerN1, spock, playerN2, scissors, spockScissors);
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3}  \n****{4}", playerN1, spock, playerN2, scissors, spockScissors, lizardSpock);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            case 5:
                                DisplayDraw();
                                Console.WriteLine("**** {0} chose: {1} \n**** Player2 {2} chose : {3}", playerN1, spock, playerN2, scissors);
                                Console.ReadLine();
                                counterPlayer1++;
                                break;
                            default:
                                Console.WriteLine("**** No a valid choice");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("**** No a valid choice");
                        break;
                }

        }
        public void PrintScore(string playerNameScore1, string playerNameScore2)
        {
            if (counterPlayer1 >= counterPlayer2)
            {
                Console.WriteLine("{0}  {1}", DisplayWins(), playerNameScore1);
                Console.WriteLine("{0}  {1}",  DisplayLoss(), playerNameScore2);
                
                string winPhraseplayer = DisplayWins();
                string appendText = String.Join(" \n", playerNameScore1, counterPlayer1);
            
                File.AppendAllText(path, appendText);
            }
            else if (counterPlayer2 >= counterPlayer1)
            {
                Console.WriteLine("{0}  {1}", DisplayWins(), playerNameScore2);
                Console.WriteLine("{0}  {1}", DisplayLoss(), playerNameScore1);

                string winPhraseplayer = DisplayWins();
                string appendText = String.Join(" \n", playerNameScore2, counterPlayer2);
              
                File.AppendAllText(path, appendText);
            }
            else
            {
                DisplayDraw();
            }
        }
    }
}
