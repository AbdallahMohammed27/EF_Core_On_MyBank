public class Branch
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public ICollection<Account> Accounts { get; set; } = new List<Account>();

    public ICollection<Empolyee>? empolyees { get; set; }

    public override string ToString()
    {
        return $"{Id}: {Name} ---- {Location}";
    }

}