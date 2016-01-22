using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace RockPaperScissor
{
    class SinglePlayer
    {
        Scissors scissors = new Scissors("Scissors");
        Rock rock = new Rock("Rock");
        Paper paper = new Paper("Paper");
        public void Rules()
        {
           
           
            Console.Clear();
            Console.WriteLine("*****************************************\n"+
                              "*****************************************\n"+
                              "**************** Choose *****************\n"+
                              "*****************************************\n"+
                              "************** 1 : {0}   **************\n"+
                              "************** 2 : {1}   ***************\n"+ 
                              "************** 3 : {2}   ***********\n"+
                              "*****************************************\n"+
                              "*****************************************\n",rock,paper,scissors);                     
        }

        public int UserChoice() 
        {
            Rules();
            string userChoice = Console.ReadLine();

            int userChoice1 = int.Parse(userChoice);
            if (userChoice1 >= 4)
            {
                Console.WriteLine("Invalid Choice...." +
                    "\n....... Please try again.....");
                Console.ReadLine();
                return
                    
                UserChoice();
            }
            else {
                return userChoice1;
            }
        }

        public int ComputerChoice()
        {
            Random df = new Random();
            int computerChoice = df.Next(1, 4);
            return computerChoice;
        }
    }
}
