using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace RockPaperScissor
{
    class WriterAndReader
    {
        string fileName = "";
        public void Writer()
        {
            Console.WriteLine("enter name:");
            fileName = Console.ReadLine(); 
        }
        public void print()
        {
            Console.WriteLine(fileName);
        }
    }
}