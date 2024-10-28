namespace LibraryManagementSystem.Models;

public abstract class LibraryItem(string title, DateTime publicationDate)
{
    public abstract int Id { get; set; }
    public abstract string Title { get; set; }
    public abstract DateTime PublicationYear { get; set; }

    public abstract void DisplayInfo();
}