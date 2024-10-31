namespace LibraryManagementSystem.Models;

public sealed class LibraryMember : Person
{
    private static int idCounter = 1;
    public override int Id { get; set; }
    public override string Name { get; set; }
    public DateTime MembershipDate { get; set; }
    
    public bool IsDeleted { get; set; }

    public LibraryMember(string name, DateTime membershipDate) : base(name) 
    {
        Name = name;
        MembershipDate = membershipDate;    
        Id = idCounter++;
        IsDeleted = false;
    }
}