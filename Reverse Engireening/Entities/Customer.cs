using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reverse_Engireening.Entities;

public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Fname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Lname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column("Birth_Date")]
    public DateOnly? BirthDate { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
