using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atbash
{
    internal class Program
    {
        static string DecryptedText(string txt)
        {
            string txtLower = txt.ToLower();
            string result = " ";

            foreach (char c in txtLower)
                result += (char)('z' - (c - 'a'));
            return result;
        }
    

        static void Main(string[] args)
        {
            Console.WriteLine(DecryptedText("abcd bvcx"));
        }
    }
}
