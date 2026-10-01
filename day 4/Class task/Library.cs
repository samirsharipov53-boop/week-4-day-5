public class Library:Book
{
    List<Book> books =new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        foreach (var item in books)
        {
            if(book.Name==item.Name) books.Remove(item);
        }
    }

    public Book SearchBookByAutor(string Au)
    {
        foreach (var item in books)
        {
            if (item.Autor == Au)
            {
                return item;
            }
        }
        return null;
    }
    public Book SearchBookByGenre(string gen)
    {
        foreach (var item in books)
        {
            if(item.Janr==gen) return item;
        }
        return null;
    }
    public int GetBoolCount()
    {
       return books.Count();
    }
}