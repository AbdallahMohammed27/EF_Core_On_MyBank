using Bank_EfCore.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Bank_EfCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            // QuaringData();
            //InsertItem();
            // UpdataOnItems();
            //DeleteItem();
            //ShowItems();
            //GetItem();
            //ExternalConfigurationRun();
            // DependencyInjectionRun();// must use optionBulider in DbContext(ExternalConfiguration)
            // ShowItemsByDataAnnotations();
            // ShowItemsByFluentApi();      
            //ShowItemsByAssembly();  
            //ShowByConfigurationEntity();
        }


        static void ShowItems()
        {
            using(var context = new InternalConfiguration.AppDbContext())
            {
                foreach(var b in context.Branchs)
                {
                    Console.WriteLine(b);
                }
            }
        }
        static void GetItem()
        {
            using (var context = new InternalConfiguration.AppDbContext())
            {
                var item = context.Branchs.First(e => e.Id == 2);
                Console.WriteLine(item);
            }
        }
        static void InsertItem()
        {
            Branch branch = new Branch
            {
                Id = 14,
                Name = "Mohammed",
                Location = "Gaza"
            };

            using(var  context = new InternalConfiguration.AppDbContext())
            {
                context.Branchs.Add(branch);// this opertion done on memory only, don't database
                context.SaveChanges();// this opertion save data on database
            }

        }

        static void UpdataOnItems()
        {
            using(var context = new InternalConfiguration.AppDbContext())
            {
                var item = context.Branchs.First(e=>e.Id==13);
                item.Location = "Alex";
                context.SaveChanges();
            }
        }

        static void DeleteItem()
        {
            using(var context = new InternalConfiguration.AppDbContext())
            {
                var item = context.Branchs.Single(e=>e.Id==12);
                context.Branchs.Remove(item);
                context.SaveChanges();  
            }
        }

        static void QuaringData()
        {
            using(var context = new InternalConfiguration.AppDbContext())
            {
                var item = context.Branchs.Where(e => e.Location == "Gaza");
                foreach(var i in item) Console.WriteLine(i);
            }
        }

        static void ExternalConfigurationRun()
        {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            var OptionBulider = new DbContextOptionsBuilder();
            OptionBulider.UseSqlServer(constr);
            DbContextOptions option = OptionBulider.Options;
            using(var context = new ExternalConfiguration.AppDbContext(option))
            {
                foreach(var b in context.Branchs) Console.WriteLine( b);
            }
        }

        static void DependencyInjectionRun()
        {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;

            var services = new ServiceCollection();

            IServiceCollection serviceCollection = services.AddDbContext<ExternalConfiguration.AppDbContext>(options=>options.UseSqlServer(constr));

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            using(var context = serviceProvider.GetService<ExternalConfiguration.AppDbContext>())
            {
                foreach(var b in context!.Branchs) Console.WriteLine(b);
            }
        }

        static void ShowItemsByDataAnnotations()
        {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            var optionBulider = new DbContextOptionsBuilder();
            optionBulider.UseSqlServer(constr);
            DbContextOptions options = optionBulider.Options;
            using(var context = new ConfigurationByDataAnnotations.AppDbContext(options))
            {
                foreach (var cus in context.tbl_Customers)
                {
                    Console.WriteLine(cus);
                }
            }
        }

        static void ShowItemsByFluentApi()
        {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            var optionBuilder = new DbContextOptionsBuilder();
            optionBuilder.UseSqlServer(constr);
            DbContextOptions options = optionBuilder.Options;
            using(var context = new ConfigurationByFluentApi.AppDbContext(options))
            {
                foreach(var tr in context.tbl_Transactions) Console.WriteLine(tr);
            }
        }

        static void ShowItemsByAssembly()
        {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            var optionBuilder = new DbContextOptionsBuilder();
            optionBuilder.UseSqlServer(constr);
            DbContextOptions options = optionBuilder.Options;
            using (var context = new ConfigruationByAssembley.AppDbContext(options))
            {
                foreach (var tr in context.Transactions) Console.WriteLine(tr);
            }
        }

        static void ShowByConfigurationEntity()
        {
            using(var context = new ConfigrutionEntity.AppDbContext())
            {
                //foreach(var a in context.transactions) Console.WriteLine(a);
                 //var account = context.transactions.Include(x=>x.Account_Id).FirstOrDefault(x=>x.TransactionId==1).Account_Id;
                //Console.WriteLine(account);
            }

        }

        
    }
}
