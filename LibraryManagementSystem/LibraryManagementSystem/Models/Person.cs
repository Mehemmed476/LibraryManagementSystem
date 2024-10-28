namespace LibraryManagementSystem.Models;

public abstract class Person(string name)
{
    public abstract int Id { get; set; }
    public abstract string Name { get; set; }
}