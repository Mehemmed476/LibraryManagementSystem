using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models;

public class BookService : IBookService
{
    List<Book> books = new List<Book>();
    
    public Book GetBookById(int id)
    {
        Book searchedBook = books.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        return searchedBook ?? throw new Exception("Book not found");
    }

    public Book[] GetAllLibraryMembers()
    {
        return books.Where(x => x.IsDeleted == false).ToArray();
    }

    public void CreateBook(Book book)
    {
        books.Add(book);
    }

    public void DeleteBook(Book book, bool IsSoftDelete)
    {
        if (IsSoftDelete)
        {
            book.IsDeleted = true;
        }
        else
        {
            books.Remove(book);
        }
    }
}