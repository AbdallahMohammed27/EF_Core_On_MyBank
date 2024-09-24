public class Empolyee // child
{
    public int Id { get; set; }

    public int Branch_Id { get; set; }

    public string Lname { get; set; }

    public string Fname {  get; set; }

    public string Title { get; set; }

    public decimal Salary { get; set; }

    public DateTime Birth_Date { get; set; }

    public Branch Branch { get; set; } = null!;// navgation -- parent -- required relationship

    public override string ToString()
    {
        return $"{Id}: {Fname} {Lname} is living {Title}, is getting salary {Salary}, and is bored in {Birth_Date}";
    }

    
}

public class Manager : Empolyee
{

}
