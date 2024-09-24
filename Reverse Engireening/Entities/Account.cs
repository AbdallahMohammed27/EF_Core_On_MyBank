using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reverse_Engireening.Entities;

public partial class Account
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Balance { get; set; }

    [Column("Customer_Id")]
    public int? CustomerId { get; set; }

    [Column("Branch_Id")]
    public int? BranchId { get; set; }

    [ForeignKey("BranchId")]
    [InverseProperty("Accounts")]
    public virtual Branch? Branch { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Accounts")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("Account")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
