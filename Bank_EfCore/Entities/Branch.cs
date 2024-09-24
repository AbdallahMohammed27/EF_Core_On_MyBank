public class Branch
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location {  get; set; }

    Account Account { get; set; }

    public override string ToString()
    {
        return $"{Id}: {Name} ---- {Location}";
    }

}