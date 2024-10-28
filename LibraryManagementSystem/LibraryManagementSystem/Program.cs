using LibraryManagementSystem.Models;

namespace LibraryManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        string choice;
        string name;
        int id;
        bool softDelete;
        DateTime hireDate;
        Librarian librarian = null;
        LibrarianService newLibrarianService = new LibrarianService();
        while (running)
        {
            Console.WriteLine("""
                              Welcome to the Library Management System!
                              
                              1. Add new Librarian
                              2. ShowAllLibrarians
                              3. ShowLibrarianById
                              4. Delete Librarian
                              5. Exit
                              """);
            Console.Write("Choose an option(1-4): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Hire Date: ");
                    hireDate = DateTime.Parse(Console.ReadLine());
                    librarian = new Librarian(name, hireDate);
                    
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
                        Console.WriteLine($"Id: {item.Id} \nName: {item.Name} \nHire Date: {item.HireDate} \nIsDeleted: {item.IsDeleted}");
                    }
                    break;
                
                case "3":
                    if (librarian == null)
                    {
                        Console.WriteLine("There is no Librarian");
                        continue;
                    }
                    Console.Write("Enter Id: ");
                    id = int.Parse(Console.ReadLine());
                    
                    Librarian searcingLibrarian = newLibrarianService.GetLibrarianById(id);
                    Console.WriteLine($"Id: {searcingLibrarian.Id} \nName: {searcingLibrarian.Name} \nHire Date: {searcingLibrarian.HireDate} \nIsDeleted: {searcingLibrarian.IsDeleted}");
                 
                    break;
                case "4":
                    Console.Write("Enter Id: ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("SoftDelete(True/False): ");
                    softDelete = bool.Parse(Console.ReadLine());
                    var librarianToDelete = newLibrarianService.GetLibrarianById(id);
                    newLibrarianService.DeleteLibrarian(librarianToDelete, softDelete);

                    Console.WriteLine("\nSuccessfully deleted Librarian.");
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("\nGoodbye");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}