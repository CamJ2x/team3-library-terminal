namespace LibraryTerminal;

public class SearchEngine
{
    public string SearchTitle()
    {
        Console.WriteLine("Let's search by the name. Enter book name: ");
        string bookName = Console.ReadLine();
        bookName = bookName.ToLower().Trim();
        List<Book> books = new List<Book>();
        foreach (Book book in books)
        {
            if (bookName == book.Title)
            {
                return book.Title;
            } ;
        }
        return "No Book Found.";
        
    }
    
    public string SearchAuthor()
    {
        Console.WriteLine("Let's search by the author. Enter book author: ");
        string bookAuthor = Console.ReadLine();
        bookAuthor = bookAuthor.ToLower().Trim();
        List<Book> books = new List<Book>();
        foreach (Book book in books)
        {
            if (bookAuthor == book.Author)
            {
                return book.Author;
            } ;
        }
        return "No Author Found.";
        
    }
    
    
}