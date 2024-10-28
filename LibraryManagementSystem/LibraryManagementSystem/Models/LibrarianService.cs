using System;
using LibraryManagementSystem.Interfaces;
using Exception = System.Exception;

namespace LibraryManagementSystem.Models;

public class LibrarianService : ILibrarianService
{
    private Librarian[] librarians = new Librarian[0];
    
    public Librarian GetLibrarianById(int id)
    {
        foreach (var librarian in librarians)
        {
            if (librarian != null && librarian.Id == id && !librarian.IsDeleted)
            {
                return librarian;
            }
        }
        throw new Exception("Librarian not found.");
    }

    public Librarian[] GetAllLibrarians()
    {
        int count = 0;

        foreach (var librarian in librarians)
        {
            if (librarian != null && !librarian.IsDeleted)
            {
                count++;
            }
        }

        Librarian[] activeLibrarians = new Librarian[count];
        int index = 0;

        foreach (var librarian in librarians)
        {
            if (librarian != null && !librarian.IsDeleted)
            {
                activeLibrarians[index++] = librarian;
            }
        }

        return activeLibrarians;
    }

    public void CreateLibrarian(Librarian librarian)
    {
        Array.Resize(ref librarians, librarians.Length + 1);
        librarians[^1] = librarian;
    }

    public void DeleteLibrarian(Librarian librarian, bool isSoftDelete)
    {
        int index = Array.IndexOf(librarians, librarian);
        if (index >= 0)
        {
            if (isSoftDelete)
            {
                librarians[index].IsDeleted = true;
            }
            else
            {
                for (int i = index; i < librarians.Length - 1; i++)
                {
                    librarians[i] = librarians[i + 1];
                }
                Array.Resize(ref librarians, librarians.Length - 1);
            }
        }
        else
        {
            throw new Exception("Librarian not found.");
        }
    }
}