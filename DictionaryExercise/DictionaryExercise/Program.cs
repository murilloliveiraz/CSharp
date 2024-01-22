using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> set = new Dictionary<string, int>();
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        set[name] = set.ContainsKey(name) ? set[name] += votes : set[name] = votes;
                    }
                }
                foreach(KeyValuePair<string, int> pair in set) 
                {
                    Console.WriteLine(pair.Key + ":" + pair.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
