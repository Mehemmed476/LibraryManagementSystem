using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces;

public interface ILibraryMemberService
{
    LibraryMember GetLibraryMemberById(int id);
    LibraryMember[] GetAllLibraryMembers();
    void CreateLibraryMember(LibraryMember libraryMember);
    void DeleteLibraryMember(LibraryMember libraryMember, bool IsSoftDelete); 
}