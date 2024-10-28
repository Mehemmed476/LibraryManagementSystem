using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces;

public interface ILibrarianService
{
    Librarian GetLibrarianById(int id);
    Librarian[] GetAllLibrarians();
    void CreateLibrarian(Librarian librarian);
    void DeleteLibrarian(Librarian librarian, bool IsSoftDelete);
}