using System;

namespace LibraryManagementSystem.Exceptions
{
    public class InvalidCatalogTypeException : Exception
    {
        public InvalidCatalogTypeException()
            : base("Invalid catalog type.") { }
    }
}