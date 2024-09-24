using System.ComponentModel.DataAnnotations.Schema;

public class Account
{
    [Column("Id")]
    public int Account_Id { get; set; }

    public decimal Balance { get; set; }    

    public int Customer_Id {  get; set; }

    public int Branch_Id {  get; set; }

    public override string ToString()
    {
        return $"{Account_Id}: {Balance} -- {Customer_Id} -- {Branch_Id}";
    }
}