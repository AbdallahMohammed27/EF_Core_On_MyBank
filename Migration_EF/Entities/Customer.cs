
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;


public class Customer
{
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }   
    public string Title { get; set; }

    public ICollection<Account>Accounts { get; set; } = new List<Account>();
    
    public DateTime Birth_Date { get; set; }

    public override string ToString()
    {
        return $"{Id} : {Fname} {Lname} ----- {Title} ------ {Birth_Date}";
    }

}