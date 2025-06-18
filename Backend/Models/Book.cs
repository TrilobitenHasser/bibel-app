namespace Backend.Models;

public class Book
{
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public int PagesCount { get; set; }
    public List<Page> Pages { get; set; } = new List<Page>();
    int Order { get; set; }

    public Book(string fullName, string shortName, int order)
    {
        FullName = fullName;
        ShortName = shortName;
        Order = order;
    }

}
