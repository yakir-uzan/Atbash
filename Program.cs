using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atbash
{
    internal class Program
    {
        static (string[],int) CounterString(string[] s, string[] wordlist)
        {
            int counter = 0;
            foreach (string word in s)
            {
                if (wordlist.Contains(word)) 
                    counter++;
            }
                                   return (s,counter); 
        }
              static void Finitefunctsoin(string[] arrya,int num)
                    {
                Console.WriteLine($"{arrya} {num}");
            
        }
        static void Main(string[] args)
        {
            string[] words = { "chamas", "til", "ptzatzza", "muchamd", "chamas", "til", "chamas", "ptzatzza", "chamas" };
         string[] problems = { "chamas", "ptzatzza" };
            var (arr,num) = CounterString(words, problems);
            Finitefunctsoin(arr, num);
        }
    }
}
