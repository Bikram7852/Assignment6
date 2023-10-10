using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Assignment6
{
    internal class SecondMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s1 = Console.ReadLine();
            LengthOfString l = new LengthOfString();
            StringLength s = new StringLength(l.StringLength);
            int ans = s(s1);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
