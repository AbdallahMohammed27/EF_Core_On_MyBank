using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class ExtentionFunctional
    {
        public static IEnumerable<Empolyee> Filter(this IEnumerable<Empolyee> source, Func<Empolyee, bool> predict)
        {
            foreach (var e in source)
            {
                if(predict(e))yield return e;
            }
        }
    }
}
