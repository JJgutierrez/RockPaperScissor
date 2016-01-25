using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace RockPaperScissor
{
   public  class PlayerChoice
    {
        public void RPSoptions()
        {
            Console.Clear();
            Console.WriteLine("****************************************************\n"+
                              "****************************************************\n"+
                              "********************* Your Choices *****************\n"+
                              "****************************************************\n"+
                              "******************** 1 : Rock    *******************\n"+
                              "******************** 2 : Paper   *******************\n"+ 
                              "******************** 3 : Scissor *******************\n"+
                              "****************************************************\n"+
                              "****************************************************\n");                     
        }
        public void RPSLSoptions()
        {
            Console.Clear();
            Console.WriteLine("****************************************************\n" +
                              "****************************************************\n" +
                              "********************* Your Choices *****************\n" +
                              "****************************************************\n" +
                              "******************** 1 : Rock    *******************\n" +
                              "******************** 2 : Paper   *******************\n" +
                              "******************** 3 : Scissor *******************\n" +
                              "******************** 4 : Lizard  *******************\n" +
                              "******************** 5 : Spock   *******************\n" +
                              "****************************************************\n" +
                              "****************************************************\n");
        }

        public int UserChoiceRPS(string playerN) 
        {
            RPSoptions();
            Console.WriteLine("******* {0} make a choice **** ", playerN);
            string userChoice = Console.ReadLine();
            int userChoice1 = int.Parse(userChoice);
            if (userChoice1 >= 4)
            {
                Console.WriteLine(".......... Invalid Choice........"+
                                "\n.......... Please try again......");
                Console.ReadLine();
                return
                UserChoiceRPS(playerN);
            }
            else {
                return userChoice1;
            }
        }
        public int UserChoiceRPSLS(string playerN)
        {
            RPSLSoptions();
            Console.WriteLine("******* {0} Make a choice **** ", playerN);
            string userChoice = Console.ReadLine();
            int userChoice2 = int.Parse(userChoice);
            if (userChoice2 >= 6)
            {
                Console.WriteLine(".......... Invalid Choice ......." +
                                 "\n......... Please try again .....");
                Console.ReadLine();
                return
                UserChoiceRPSLS(playerN);
            }
            else
            {
                return userChoice2;
            }
        }
        public int ComputerChoiceRPS()
        {
            RPSoptions();
            Random rps = new Random();
            int computerChoice = rps.Next(1, 4);
            return computerChoice;
        }
        public int ComputerChoiceRPSLS()
        {
            Random rpsls = new Random();
            int computerChoice = rpsls.Next(1, 6);
            return computerChoice;
        }
    }
}
