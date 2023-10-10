using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate string MakeFirstCharacterUppecase(string s);
    public class UppercaseCharacter
    {
        public string MakeFirstCharacterUppecase(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
