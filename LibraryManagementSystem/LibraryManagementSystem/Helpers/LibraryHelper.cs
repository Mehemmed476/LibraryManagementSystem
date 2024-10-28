using System.Text;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Helpers;

public static class LibraryHelper
{
    public static int CalculateAge(this LibraryItem item)
    {
        return DateTime.Now.Year - item.PublicationYear.Year;
    }

    public static string ToTitleCase(this LibraryItem item)
    {
        StringBuilder result = new StringBuilder();
        string word = item.Title;
        
        result.Append(char.ToUpper(word[0]));
        result.Append(word.Substring(1, word.Length-1).ToLower());
        return result.ToString();
    }
}