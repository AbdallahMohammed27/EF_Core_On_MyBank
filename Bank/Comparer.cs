using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Comparer : IComparer<Empolyee>
    {
        public int Compare(Empolyee e1, Empolyee e2)
        {
            if (e1.Salary == e2.Salary) return e1.Fname.CompareTo(e2.Fname);
            return e1.Salary.CompareTo(e2.Salary);
        }
    }
}
