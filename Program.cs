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
        static string[] convertText(string txt)
        {
            string txtLower = txt.ToLower();
            string result = "";

            foreach (char c in txtLower)
            {
                if (c >= 'a' && c <= 'z')
                    result += (char)('z' - (c - 'a'));

                else
                    result += c;
            }
            string[] convTxt = result.Split(' ');
            return convTxt;
        }
    

        static void Main(string[] args)
        {
            Console.WriteLine(convertText("\r\nLfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb. \r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo. \r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. \r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm. \r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.\r\n"));
        }
    }
}
