using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RockPaperScissor
{
    interface IGetNames
    {
        string PlayerName1();
        string PlayerName2();

    }
   public  class PlayersEntry
    {
        
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*****************************************"+
                             "\n***** ROCK **** PAPPER **** SCISSOR *****"+
                            "\n*****************************************"+
                            "\n*****************************************");
        }

        public string PlayerName1()
        {
            Console.WriteLine("Please Enter Your Name:  ");
            string name = Console.ReadLine();
            return name;
        }
        public string PlayerName2()
        {
            Console.WriteLine("Please Enter Your Name:  ");
            string name1 = Console.ReadLine();
            return name1;
        }


        public void Choice()
        {
            Thread.Sleep(3000);
            Console.Clear();
            
            Console.WriteLine("****************************\n"+
                              "***** Make a Selection  : **\n" +
                              "*****1 : One Player ********\n" +
                              "*****2 : Two Players *******\n"+
                              "****************************");
            string choises = Console.ReadLine();
            int choise = int.Parse(choises);
            try
            {
                switch (choise)
                {
                    case 1:
                        
                      
                        break;
                    case 2:
                        
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("No a Valid Option ..Try again!!");
                        Choice();
                        
                        break;

                }

            }
            catch
            {


            }


        }
    }
}
