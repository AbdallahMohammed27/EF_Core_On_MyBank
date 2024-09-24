using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

public class Transaction
{

    public int TransactionId { get; set; }

    public int Account_Id {  get; set; }
    
    public decimal Amount {  get; set; }
  
    public DateTime TimeTamp { get; set; }

    public Account Account { get; set; } = null!;

    public override string ToString()
    {
        return $"{TransactionId}: {Account_Id} --- {Amount} --- {TimeTamp}";
    }
}