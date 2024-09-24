using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var list = Repos.LoadEmpoyees();
            ////where don't new list in memory but do reference on list that wanted.
            //var EmployeesStartWithA = list.Where(e => e.Lname.ToLower().StartsWith('a'));
            //var EmployeesSalaryGreaterThanOrEquel1000 = list.Where(e => e.Salary >= 1000);
            //var EmployeesBirthDateGreaterThanOrEquel2000 = list.Where(e => e.Birth_Date.Year >= 2000);
            //var EmployeesTitleGaza = list.Where(e => e.Title == "Gaza");
            //foreach (var employee in EmployeesTitleGaza)
            //{
            //    Console.WriteLine(employee);
            //}



            //List<int> list = new List<int> { 1,2,4,7,6};
            //// method syntax
            //IEnumerable<int> even1 = list.Where(e => e % 2 == 0);// lazy
            //// quary syntax
            //IEnumerable<int>even2=from i in list
            //                      where i % 2 == 0
            //                      select i;

            //list.Add(5);
            //list.Add(10);
            //list.Remove(4);

            //foreach(int i in even2) Console.WriteLine(i);


            //List<string> list = new List<string> { "I", "love", "allah"};
            // var list2 = list.Select(e => e.ToUpper());
            // var list3 = from e in list select e.ToUpper();
            // foreach(var item in list3) Console.WriteLine(item);


            //List<string> list = new List<string> { "I love allah", "I love mohammed" };

            //var list2 = list.SelectMany(x => x.Split(' '));
            //var list3 = from x in list from y in x.Split(' ') select y;
            //foreach ( var x in list2) Console.WriteLine(x);


            //List<string> ColorName = new List<string> { "Red", "Green", "Blue"};
            //List<string> ColorNum = new List<string> { "FF0000", "00FF00","0000FF" };
            //List<int> ColorDegree = new List<int> { 1,2,3};
            //List<int> ColorNumDegrees = new List<int> { 44, 55, 33 };
            //var ThreeFirst = ColorName[^2..];
            //foreach(var item in ThreeFirst) Console.WriteLine(item);

            //var join = ColorName.Zip(ColorNum).Zip(ColorDegree).Zip(ColorNumDegrees);
            //foreach (var item in join) Console.WriteLine(item);




            //List<string> list = new List<string> { "Omer", "Mohammed", "Ali"};
            //var ListOrder = list.OrderBy(x => x);
            //var ListOrder2 = from x in list orderby x select x;
            //var ListOrderDes = list .OrderByDescending(x => x);
            //var ListOrderDes2 = from x in list orderby x descending select x;
            //foreach (var item in ListOrderDes2) Console.WriteLine(item);


            //var employees = Repos.LoadEmpoyees();
            //var employeesSortedThen = employees.OrderBy(employee => employee.Fname).ThenBy(Empolyee=>Empolyee.Lname).ThenBy(employee=>employee.Salary);
            //foreach (var employee in employeesSortedThen) Console.WriteLine(employee);


            //var employees = Repos.LoadEmpoyees();
            //var employeessortedComparer = employees.OrderBy(employees => employees, new Comparer());
            //foreach (var employee in employeessortedComparer) Console.WriteLine(employee);



            //var employees = Repos.LoadEmpoyees();
            //var q1 = employees.Skip(5);
            //var q2 = employees.SkipWhile(x => x.Salary!=9990.32m);
            //var q3 = employees.SkipLast(5);

            //var tq1 = employees.Take(5);
            //var tq2 = employees.TakeWhile(x=>x.Salary != 9990.32m);
            //var tq3 = employees.TakeLast(5);

            //var chq1 = employees.Chunk(5).ToList();
            //foreach (var employee in chq1)
            //{
            //    foreach(var e in employee)
            //    {
            //        Console.WriteLine(e);
            //    }
            //    Console.WriteLine("___________________________________________");
            //}


            //var employees = Repos.LoadEmpoyees();
            //var q1 = employees.Any(x=>x.Salary<1000);
            //var q2 = employees.All(x=>x.Salary>=1000);
            //var q3 = employees.Any(x=>x.Lname.Contains("a"));
            //var e = new Empolyee { Lname = "mohamed" };
            //var q4 = employees.Contains(e);

            //Console.WriteLine(q4);



            //var employees = Repos.LoadEmpoyees();
            //var q1 = employees.GroupBy(e=>e.Id);//deferred execution
            //var q2 = employees.ToLookup(e=>e.Id);//immediate execution


            //foreach (var q in q2)
            //{
            //    Console.WriteLine(q.Key);
            //    // foreach (var e in q) Console.WriteLine(e);
            //    Console.WriteLine("______________________________________________");
            //}


            //var employees = Repos.LoadEmpoyees();
            //var branchs=Repos.LoadBranchs();

            //var result = employees.join(
            //    branchs, 
            //    e => e.branch_id, 
            //    b => b.id, 
            //    (emp, bran) => new {
            //        emp=emp.fname,bran=bran.location
            //    });



            //var result2 = from emp in employees
            //              join bran in branchs
            //              on emp.Branch_Id equals bran.Id
            //              select new
            //              {
            //                  e = emp.Fname,
            //                  b = bran.Location
            //              };


            //foreach (var emp in result2) Console.WriteLine(emp);

            // Console.WriteLine(default(int));

            // var range = Enumerable.Range(1, 10);
            //// foreach (var i in range) Console.WriteLine(i);
            // var repeat = Enumerable.Repeat(range, 10);
            // foreach(var i in repeat)
            // {
            //     foreach(var j in i) Console.WriteLine(j);
            //     Console.WriteLine("########################################################################");
            // }


           // var employees = Repos.LoadEmpoyees();
            //Console.WriteLine(employees.ElementAt(0));
            //Console.WriteLine(employees.ElementAtOrDefault(10));
            // Console.WriteLine(employees.First(e=>e.Salary > 1000));
            // Console.WriteLine(employees.FirstOrDefault(e=>e.Salary > 100000000));
            //Console.WriteLine(employees.Last(e=>e.Salary > 1000));
            //Console.WriteLine(employees.LastOrDefault(e=>e.Salary>1000000000));
            //Console.WriteLine(employees.Single(e=>e.Salary > 1000));//exception
            //Console.WriteLine(employees.SingleOrDefault(e=>e.Salary > 1000)); // exception, find more than one
            //Console.WriteLine(employees.SingleOrDefault(e=>e.Salary > 1000000)); // null, not find salary > 1000000


          //  var e1 = employees.ElementAt(0);
          //  var e2 = employees.ElementAt(1);
          //  var e3 = employees.ElementAt(2);

          //  //var random = new Random();

          //  //var e1 = employees.ElementAt(random.Next(1,3));
          //  //var e2 = employees.ElementAt(random.Next(1, 3));
          //  //var e3 = employees.ElementAt(random.Next(1, 3));

          //  //List<Empolyee>list1= new List<Empolyee>{ e1,e2,e3};
          //  //List<Empolyee>list2 = new List<Empolyee>{e1,e2,e3};

          //  //Console.WriteLine(list2.SequenceEqual(list1));

          // // List<Empolyee>list1 = new List<Empolyee> { e1,e2};
          ////  List<Empolyee> list2 = new List<Empolyee> { e3 }; 

          //  List<Empolyee> ListContcat = list1.Concat(list2).ToList();
          // // foreach(var i  in ListContcat) Console.WriteLine(i);
          // List<string> ListContcatTitles = list1.Select(e => e.Title).Concat(list2.Select(e=>e.Title)).ToList();
          //  //foreach(var i in ListContcatTitles) Console.WriteLine(i);
          //  var ListContcatInstanition = new[] {list1 , list2}.SelectMany(e=>e);
          //  //foreach(var i in ListContcatInstanition) Console.WriteLine(i);
          //  List<string> names = new List<string> { "Abdallah", "Mohammed", "Mostafa" };
          //  string res = string.Join(' ', names);
          //  string res2 = names.Aggregate((a, b) =>$"{a} {b}");// same accumulate in c++, a is old value, b is new value
          //  //Console.WriteLine(res2);
          // // Console.WriteLine(res.Count());
          //  //Console.WriteLine(res.Length);

          //  var MaxSalary = employees.Max(e=>e.Salary);// return value
          //  var WhoMaxSalary = employees.MaxBy(e=>e.Salary);//return instance
          //  var MinSalary = employees.Min(e => e.Salary);// return value
          //  var WhoMinSalary = employees.MinBy(e => e.Salary);//return instance
          //  //Console.WriteLine(MaxSalary);
          //  //Console.WriteLine(MinSalary);
          //  var Salaries = employees.Sum(e=>e.Salary);
          //  var Avg = employees.Average(e=>e.Salary);
            //Console.WriteLine(Salaries);
            //Console.WriteLine(Avg);

           // List<string> ListContcatTitlesDistict = list1.Select(e => e.Title).Concat(list2.Select(e => e.Title)).ToList();
            //ListContcatTitlesDistict = ListContcatTitlesDistict.Distinct().ToList();//DistinctBy
            //foreach(var i in ListContcatTitlesDistict) Console.WriteLine(i);

            //var list1 = new List<int> { 1,2,3,4};
            //var list2 = new List<int> {3,4};
            //var res = list1.Except(list2);//ExceptBy
            //var inter = list1.Intersect(list2);
            //var uni = list2.Union(list1);// numbers is distict
            ////foreach (var item in res) Console.WriteLine(item);
            //foreach (var item in uni) Console.WriteLine(item);

            //Func<int,int,bool>del=(num1,num2)=>num1%2==0&&num2%2==0;
            //Expression<Func<int, bool>> IsOdd = (num) => ((num&1)==1);
            //Expression<Func<int, bool>> IsNegative = (num) => (num < 0);
            //Func<int,bool>IsOdd2 = IsOdd.Compile();
            //Console.WriteLine(del(2,4));
            //Console.WriteLine(IsOdd2(3));

            //ParameterExpression num = IsOdd.Parameters[0];
            //BinaryExpression opertaion = (BinaryExpression)IsOdd.Body;
            //BinaryExpression operation2 = (BinaryExpression)opertaion.Left;
            //ParameterExpression left = (ParameterExpression)operation2.Left;
            //ConstantExpression right = (ConstantExpression)opertaion.Right;
            //Console.WriteLine($"{num.Name} {opertaion.NodeType} {operation2.NodeType} {right.Value}");

            // (num)=>num>0

           // ParameterExpression num = Expression.Parameter(typeof(int), "num");
           // ConstantExpression con = Expression.Constant(0);
           //// ParameterExpression left = Expression.Parameter(typeof(int), "num");
           // BinaryExpression bady = Expression.GreaterThan(num, con);
           // Expression<Func<int, bool>> IsPositive = Expression.Lambda<Func<int,bool>>(bady,new ParameterExpression[] { num});
           // Func<int,bool>Ispostive=IsPositive.Compile();
           // Console.WriteLine(Ispostive(3));

           
        }

    }
}
