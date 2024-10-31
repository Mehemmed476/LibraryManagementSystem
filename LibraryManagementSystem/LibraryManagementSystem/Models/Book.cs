using System.Text.Json.Serialization.Metadata;
using LibraryManagementSystem.Enums;

namespace LibraryManagementSystem.Models;

public class Book : LibraryItem
{
    private static int idCounter = 1;
    public override int Id { get; set; }
    public override string Title { get; set; }
    public override DateTime PublicationYear { get; set; }
    public BookJenre Genre { get; set; }
    
    public LibraryLocation Location { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public Book(string title, DateTime publicationYear, BookJenre genre) : base(title, publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
        Genre = genre;
        Id = idCounter++;
        IsDeleted = false;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"<Book> \nTitle: {Title} \nGenre: {Genre} \nPublication Year: {PublicationYear}");
    }
}