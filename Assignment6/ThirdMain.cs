using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Assignment6
{
    internal class ThirdMain:EventArgs
    {
        public static event greet DoGreet;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string s = Console.ReadLine();
            Greet g = new Greet();
            DoGreet += new greet(g.greet);
            string ans = DoGreet(s);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
