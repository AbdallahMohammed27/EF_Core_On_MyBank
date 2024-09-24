using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class ExtentionProcedual
    {
        public static IEnumerable<Empolyee>GetEmployeeWithFirstNameStartWith(string value)
        {
            IEnumerable < Empolyee >empolyees = Repos.LoadEmpoyees();
            foreach(var em in empolyees)
            {
                if(em.Lname.ToLower().StartsWith(value.ToLower()))
                {
                    yield return em;
                }
            }
        }

        public static IEnumerable<Empolyee>GetEmployeeWihtFirstNameEndWiht(string value)
        {
            IEnumerable <Empolyee> empolyees=Repos.LoadEmpoyees();
            foreach (var em in empolyees)
            {
                if (em.Lname.ToLower().EndsWith(value.ToLower()))
                {
                    yield return em;
                }
            }
        }

        public static IEnumerable<Empolyee> GetEmployeeTheirBirthDateGreaterOrEquelThan(int year)
        {
            IEnumerable<Empolyee>empolyees=Repos.LoadEmpoyees();
            foreach(var em in empolyees)
            {
                if(em.Birth_Date.Year <= year)
                {
                    yield return em;
                }
            }
        }

        public static IEnumerable<Empolyee>GetEmployeeTheirTitle(string city)
        {
            IEnumerable <Empolyee> empolyees =Repos.LoadEmpoyees();
            foreach( var em in empolyees)
            {
                if(em.Title.ToLower()==city.ToLower())
                {
                    yield return em;
                }
            }
        }

        public static IEnumerable<Empolyee> GetEmployeeTheirSalaryLessThanOrEquel(decimal salary)
        {
            IEnumerable<Empolyee>empolyees =Repos.LoadEmpoyees();
            foreach ( var em in empolyees)
            {
                if (em.Salary >= salary)
                {
                    yield return em;
                }
            }
        }
    }
}
