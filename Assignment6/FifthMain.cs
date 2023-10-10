using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Assignment6
{
    internal class FifthMain:EventArgs
    {
        public static event CalculateLeaves DoCalculateLeaves;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of days you want to leave");
            int n = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee();
            employee.Leaves = 10;
            DoCalculateLeaves += new CalculateLeaves(employee.CalculateLeaves);
            int ans = DoCalculateLeaves(n);
            Console.WriteLine("The balance leaves you have: " + ans);
            Console.ReadLine();
        }
    }
}
