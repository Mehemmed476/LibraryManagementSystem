namespace LibraryManagementSystem.Models;

public class Magazine : LibraryItem
{
    private static int idCounter = 1;
    public override int Id { get; set; }
    public override string Title { get; set; }
    public override DateTime PublicationYear { get; set; }

    public Magazine(string title, DateTime publicationYear) : base(title, publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
        Id = idCounter++;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"<Magazine> \nTitle: {Title} \nPublication Year: {PublicationYear}");
    }
}