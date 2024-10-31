using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models;

public class LibraryMemberService : ILibraryMemberService
{
    public static List<LibraryMember> libraryMembers = new List<LibraryMember>();


    public LibraryMember GetLibraryMemberById(int id)
    {
        LibraryMember libraryMember = libraryMembers.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        return libraryMember ?? throw new Exception("Library member not found.");
    }

    public LibraryMember[] GetAllLibraryMembers()
    {
        return libraryMembers.Where(x => x.IsDeleted == false).ToArray();
    }

    public void CreateLibraryMember(LibraryMember libraryMember)
    {
        libraryMembers.Add(libraryMember);
    }

    public void DeleteLibraryMember(LibraryMember libraryMember, bool IsSoftDelete)
    {
        if (IsSoftDelete)
        {
            libraryMember.IsDeleted = true;
        }
        else
        {
            libraryMembers.Remove(libraryMember);
        }
    }
}