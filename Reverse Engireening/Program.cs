using Reverse_Engireening.Data;

namespace Reverse_Engireening
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BankContext())
            {
                foreach(var e in context.Employees) Console.WriteLine(e.Fname);
            }
        }
    }
}
