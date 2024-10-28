using System.Text.Json.Serialization.Metadata;

namespace LibraryManagementSystem.Models;

public class Book : LibraryItem
{
    private static int idCounter = 1;
    public override int Id { get; set; }
    public override string Title { get; set; }
    public override DateTime PublicationYear { get; set; }
    public string Genre { get; set; }
    
    public Book(string title, DateTime publicationYear, string genre) : base(title, publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
        Genre = genre;
        Id = idCounter++;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"<Book> \nTitle: {Title} \nGenre: {Genre} \nPublication Year: {PublicationYear}");
    }
}