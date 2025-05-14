using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atbash
{
    internal class Program
    {
        static Dictionary<string, int> CounterString(string[] s, string[] wordlist)
        {
            Dictionary<string, int> problematicwords = new Dictionary<string, int>();
            foreach (string word in s)
            {
                if (wordlist.Contains(word))
                {
                    if (problematicwords.ContainsKey(word))
                    {
                        problematicwords[word] ++;
                    }
                    else problematicwords[word] = 1;
                }
                else problematicwords[word] = 0;
            }
                print(problematicwords);
                        return problematicwords;
        }
        static void print(Dictionary<string, int> d)
        {
            foreach (var word in d)
            {
                Console.WriteLine(word);
            }
        }
        static void Main(string[] args)
        {
            string[] words = { "chamas", "til", "ptzatzza", "muchamd", "chamas", "til", "chamas", "ptzatzza", "chamas" };
         string[] problems = { "chamas", "ptzatzza" };
            CounterString(words, problems);
            //Dictionary<string,int>dd = new Dictionary<string,int>();
            //dd["chamas"] = 1;
            //dd["pzzatzza"] = 5;

            //print();        }
        }
    }
}
