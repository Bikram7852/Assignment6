using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate string greet(string s);
    public class Greet
    {
        public string greet(string s) 
        {
            string g = "Hello " + s;
            return g;
        }
    }
}
