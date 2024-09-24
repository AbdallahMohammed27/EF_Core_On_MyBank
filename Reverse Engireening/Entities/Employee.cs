using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reverse_Engireening.Entities;

public partial class Employee
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

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Salary { get; set; }

    [Column("Birth_Date")]
    public DateOnly? BirthDate { get; set; }

    [Column("Branch_Id")]
    public int? BranchId { get; set; }

    [ForeignKey("BranchId")]
    [InverseProperty("Employees")]
    public virtual Branch? Branch { get; set; }
}
