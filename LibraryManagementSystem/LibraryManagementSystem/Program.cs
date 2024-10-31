using LibraryManagementSystem.Models;

namespace LibraryManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        string choice;
        while (running)
        {
            Console.WriteLine("""
                              Welcome to the Library Management System! 

                              1. Librarian Management
                              2. Library Member Management
                              3. Book Management
                              4. Quit the Application
                              """);

            Console.Write("Select an option(1-4): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Librarian librarian = null;
                    LibrarianService newLibrarianService = new LibrarianService();
                    bool runningLibrarian = true;
                    while (runningLibrarian)
                    {
                        Console.WriteLine("""
                                          1. Add new Librarian
                                          2. ShowAllLibrarians
                                          3. ShowLibrarianById
                                          4. Delete Librarian
                                          5. Exit
                                          """);
                        Console.Write("Choose an option(1-5): ");
                        choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                string librarianName;
                                DateTime hireDate;
                                Console.Write("Enter Name: ");
                                librarianName = Console.ReadLine();
                                Console.Write("Enter Hire Date: ");
                                hireDate = DateTime.Parse(Console.ReadLine());
                                librarian = new Librarian(librarianName, hireDate);

                                newLibrarianService.CreateLibrarian(librarian);
                                break;

                            case "2":
                                if (librarian == null)
                                {
                                    Console.WriteLine("There is no Librarian");
                                    continue;
                                }

                                Librarian[] librarians = newLibrarianService.GetAllLibrarians();

                                foreach (Librarian? item in librarians)
                                {
                                    Console.WriteLine(
                                        $"Id: {item.Id} \nName: {item.Name} \nHire Date: {item.HireDate} \nIsDeleted: {item.IsDeleted}");
                                }

                                break;

                            case "3":
                                if (librarian == null)
                                {
                                    Console.WriteLine("There is no Librarian");
                                    continue;
                                }

                                int librarianId;
                                Console.Write("Enter Id: ");
                                librarianId = int.Parse(Console.ReadLine());

                                Librarian searcingLibrarian = newLibrarianService.GetLibrarianById(librarianId);
                                Console.WriteLine(
                                    $"Id: {searcingLibrarian.Id} \nName: {searcingLibrarian.Name} \nHire Date: {searcingLibrarian.HireDate} \nIsDeleted: {searcingLibrarian.IsDeleted}");

                                break;
                            case "4":
                                bool softDelete;
                                Console.Write("Enter Id: ");
                                librarianId = int.Parse(Console.ReadLine());
                                Console.Write("SoftDelete(True/False): ");
                                softDelete = bool.Parse(Console.ReadLine());
                                var librarianToDelete = newLibrarianService.GetLibrarianById(librarianId);
                                newLibrarianService.DeleteLibrarian(librarianToDelete, softDelete);

                                Console.WriteLine("\nSuccessfully deleted Librarian.");
                                break;
                            case "5":
                                runningLibrarian = false;
                                Console.WriteLine("\nGoodbye");
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }

                    break;
                case "2":
                    LibraryMember libraryMember = null;
                    LibraryMemberService newLibraryMemberService = new LibraryMemberService();
                    bool runningLibraryMember = true;
                    while (runningLibraryMember)
                    {
                        Console.WriteLine("""
                                          1. Add new LibraryMember
                                          2. ShowAllLibraryMember
                                          3. ShowLibraryMemberById
                                          4. Delete LibraryMember
                                          5. Exit
                                          """);
                        Console.Write("Choose an option(1-5): ");
                        choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                string libraryMemberName;
                                DateTime membershipDate;
                                Console.Write("Enter Name: ");
                                libraryMemberName = Console.ReadLine();
                                Console.Write("Enter Hire Date: ");
                                membershipDate = DateTime.Parse(Console.ReadLine());
                                libraryMember = new LibraryMember(libraryMemberName, membershipDate);

                                newLibraryMemberService.CreateLibraryMember(libraryMember);
                                break;

                            case "2":
                                if (libraryMember == null)
                                {
                                    Console.WriteLine("There is no LibraryMember");
                                    continue;
                                }

                                LibraryMember[] libraryMembers = newLibraryMemberService.GetAllLibraryMembers();

                                foreach (LibraryMember? item in libraryMembers)
                                {
                                    Console.WriteLine(
                                        $"Id: {item.Id} \nName: {item.Name} \nMembership Date: {item.MembershipDate} \nIsDeleted: {item.IsDeleted}");
                                }

                                break;

                            case "3":
                                if (libraryMember == null)
                                {
                                    Console.WriteLine("There is no LibraryMember");
                                    continue;
                                }

                                int id;
                                Console.Write("Enter Id: ");
                                id = int.Parse(Console.ReadLine());

                                LibraryMember searcingLibraryMember = newLibraryMemberService.GetLibraryMemberById(id);
                                Console.WriteLine(
                                    $"Id: {searcingLibraryMember.Id} \nName: {searcingLibraryMember.Name} \nMembership Date: {searcingLibraryMember.MembershipDate} \nIsDeleted: {searcingLibraryMember.IsDeleted}");

                                break;
                            case "4":
                                bool softDelete;
                                Console.Write("Enter Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("SoftDelete(True/False): ");
                                softDelete = bool.Parse(Console.ReadLine());
                                var libraryMemberToDelete = newLibraryMemberService.GetLibraryMemberById(id);
                                newLibraryMemberService.DeleteLibraryMember(libraryMemberToDelete, softDelete);

                                Console.WriteLine("\nSuccessfully deleted LibraryMember.");
                                break;
                            case "5":
                                runningLibraryMember = false;
                                Console.WriteLine("\nGoodbye");
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }

                    break;
            }
        }
    }
}