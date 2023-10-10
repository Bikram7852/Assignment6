using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate int StringLength(string s1);
    public class LengthOfString
    {
        public int StringLength(string s1)
        {
            return s1.Length;
        }
    }
}
