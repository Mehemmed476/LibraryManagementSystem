namespace LibraryManagementSystem.Models;

public class DVD : LibraryItem
{
    private static int idCounter = 1;
    public override int Id { get; set; }
    public override string Title { get; set; }
    public override DateTime PublicationYear { get; set; }

    public DVD(string title, DateTime publicationYear) : base(title, publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
        Id = idCounter++;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"<DVD> \nTitle: {Title} \nPublication Year: {PublicationYear}");
    }
}