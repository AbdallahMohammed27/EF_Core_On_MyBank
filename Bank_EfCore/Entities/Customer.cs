
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Customers")]// this name is Database table's name
public class Customer
{
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }   
    public string Title { get; set; }
    
    public DateTime Birth_Date { get; set; }

    public override string ToString()
    {
        return $"{Id} : {Fname} {Lname} ----- {Title} ------ {Birth_Date}";
    }

}