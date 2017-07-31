using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace changeCheck
{
    class Occurences
    {
        public void Occur()
        {
            StreamReader reading = new StreamReader(@"D:\data.txt");

            string[] data = File.ReadAllLines(@"D:\data.txt");

            List<string> dummy = new List<string>();

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach(string line in data)
            {
                if(line == "161480")
                {

                }
                if(dummy.Contains(line))
                {
                    count[line] = (count.ContainsKey(line)) ? count[line] + 1 : 1;
                }
                else
                    dummy.Add(line);
            }
        }
    }
}
