using System.ComponentModel.DataAnnotations.Schema;

public class Account
{
    public int Account_Id { get; set; }

    public decimal Balance { get; set; }    

    public int Customer_Id {  get; set; }

    public int Branch_Id {  get; set; }

    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public Branch Branch { get; set; } = null!;

    public Customer Customer { get; set; } = null!;

    public override string ToString()
    {
        return $"{Account_Id}: {Balance} -- {Customer_Id} -- {Branch_Id}";
    }
}