using System.Runtime.CompilerServices;

namespace Backend.Models;

public class Page
{
    int Chapter { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    public Page(int chapter, string title, string text)
    {
        Chapter = chapter;
        Title = title;
        Text = text;
    }
}
