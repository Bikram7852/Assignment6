using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate int CalculateLeaves(int noOfDays);
    public class Employee
    {
		private int _Leaves;
        public int Leaves
        {
            get { return _Leaves; }
            set { _Leaves = value; }
        }
        public int CalculateLeaves(int noOfDays)
        {
            Leaves = Leaves - noOfDays;
            return Leaves;
        }

	}
}
