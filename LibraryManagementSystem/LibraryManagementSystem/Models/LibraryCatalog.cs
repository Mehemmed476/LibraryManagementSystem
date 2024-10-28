using LibraryManagementSystem.Enums;
using LibraryManagementSystem.Exceptions;

namespace LibraryManagementSystem.Models;

public class LibraryCatalog
{
    private Book[] books;
    private Magazine[] magazines;
    private DVD[] dvds;

    public LibraryCatalog()
    {
        books = new Book[0];
        magazines = new Magazine[0];
        dvds = new DVD[0];
    }

    public object this[CatalogTypes catalogType, int index]
    {
        get
        {
            try
            {
                return catalogType switch
                {
                    CatalogTypes.books => books[index],
                    CatalogTypes.magazines => magazines[index],
                    CatalogTypes.dvds => dvds[index],
                    _ => throw new InvalidCatalogTypeException()
                };
            }
            catch
            {
                throw new CatalogItemNotFoundException(index);
            }
        }
        set
        {
            try
            {
                switch (catalogType)
                {
                    case CatalogTypes.books:
                        books[index] = (Book)value;
                        break;
                    case CatalogTypes.magazines:
                        magazines[index] = (Magazine)value;
                        break;
                    case CatalogTypes.dvds:
                        dvds[index] = (DVD)value;
                        break;
                    default:
                        throw new InvalidCatalogTypeException();
                }
            }
            catch
            {
                throw new CatalogItemNotFoundException(index);
            } 
        }
    }
}