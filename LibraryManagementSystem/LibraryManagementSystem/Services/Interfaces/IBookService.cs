using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces;

public interface IBookService
{
    Book GetBookById(int id);
    Book[] GetAllLibraryMembers();
    void CreateBook(Book book);
    void DeleteBook(Book book, bool IsSoftDelete); 
}