using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string s2 = Console.ReadLine();
            concatenation c = new concatenation();
            AttachStringToEachOther s = new AttachStringToEachOther(c.ConcatStrings);
            string ans = s(s1, s2);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
