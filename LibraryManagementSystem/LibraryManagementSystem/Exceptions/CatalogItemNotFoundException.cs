namespace LibraryManagementSystem.Exceptions
{
    public class CatalogItemNotFoundException : Exception
    {
        public CatalogItemNotFoundException(int index)
            : base($"The requested catalog item could not be found for index {index}.") { }
    }
}


