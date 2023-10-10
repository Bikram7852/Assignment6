using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Assignment6
{
    internal class FourthMain:EventArgs
    {
        public static event MakeFirstCharacterUppecase DoUppercase;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            UppercaseCharacter u = new UppercaseCharacter();
            DoUppercase += new MakeFirstCharacterUppecase(u.MakeFirstCharacterUppecase);
            string ans = DoUppercase(s);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
