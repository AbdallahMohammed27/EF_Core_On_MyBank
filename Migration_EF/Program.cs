using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Migration_EF
{
    public class Program
    {
       public static async Task Main(string[] args)
        {
            using(var context = new AppDbContext())
            {
                //  await context.Database.EnsureCreatedAsync();
                //  var sql = context.Database.GenerateCreateScript();
                ////  Console.WriteLine(sql);
                //  await Task.Delay(30000);
                //  await context.Database.EnsureDeletedAsync();

                // var account = context.Set<Account>();
                // Console.WriteLine( account.ToQueryString());


                //var join = context.Set<Account>()
                //            .Include(e => e.Branch)
                //            .Include(e => e.Transactions)
                //            .Select(e=> new {
                //               AccountId = e.Account_Id,
                //               BranchId = e.Branch_Id,
                //               Amount=e.Balance,
                //               CustomerId = e.Customer_Id
                //});
                //foreach (var item in join) Console.WriteLine(item);


                //var accounts = context.Set<Account>().FromSql($"select * from accounts");
                //foreach (var account in accounts) Console.WriteLine(account);

                //var accountId = new SqlParameter("@AccountId", 1);
                //var account = context.Set<Account>().FromSqlRaw($"select * from accounts where Account_Id = @AccountId", accountId).FirstOrDefault();
                //Console.WriteLine(account); // the pass parameter is more safe in FromSqlRaw, the fromSql is defualt safe

                // var new_account = new Account { Account_Id=2, Balance = 9484.93m, Customer_Id = 1, Branch_Id = 1};
                //context.Set<Account>().Add(new_account);
                //var new_empolyee = new Empolyee { Id=2,Birth_Date = new DateTime(2001,1,1), Branch_Id = 1, Fname = "ahmed", Lname = "omer",Salary=9404,Title="Luxor"};
                //context.Set<Empolyee>().Add(new_empolyee);
                //await context.SaveChangesAsync();
               
            }
        }
    }
}
