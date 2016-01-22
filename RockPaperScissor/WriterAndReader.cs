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
        string fileName = @"PlayersData.txt";
        public void Writer()
        {


            if (File.Exists(fileName))
            {
                Dictionary<string, string> allPlayer = new Dictionary<string, string>();
                using (var sr = new StreamReader(fileName))
                {
                    string line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        // add the key and whatever it 
                        // can read next as the value
                        allPlayer.Add(line, sr.ReadLine());
                    }

                }
            }
            else
            {
                File.Create(fileName);


            }
        }
    }
}