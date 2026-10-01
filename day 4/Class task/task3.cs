using System.Security.Cryptography.X509Certificates;

public class Bookk
{
    public string? Title{get;set;}
    public string? NameAutor{get;set;}
    public int Page{get;set;}
    public int BookYear;

    public Bookk(){}
    public Bookk(string Title, string Autor, int Page, int Year)
    {
        this.BookYear=Year;
        this.Page=Page;
        this.NameAutor=Autor;
        this.Title=Title;
    }

    public void _Title()
    {
       System.Console.WriteLine("Name of Book: "+Title);
    }
    public void _Page()
    {
        System.Console.WriteLine("Page of Book: "+Page);
    }
    public void _Year()
    {
        System.Console.WriteLine("Year of Book: "+BookYear);
    }
    public void _AutorBook()
    {
        System.Console.WriteLine("Autor of Book: "+NameAutor);
    }
    public void EveryThing()
    {
        _Title();
        _AutorBook();
        _Page();
        _Year();
    }
}