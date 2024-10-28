namespace LibraryManagementSystem.Models;

public class Librarian : Person
{
    private static int idCounter = 1;
    public override int Id { get; set; }
    public override string Name { get; set; }
    public DateTime HireDate { get; set; }
    public bool IsDeleted { get; set; }
    public Librarian(string name, DateTime hireDate) : base(name)
    {
        Name = name;
        HireDate = hireDate;
        Id = idCounter++;
        IsDeleted = false;
    }
}