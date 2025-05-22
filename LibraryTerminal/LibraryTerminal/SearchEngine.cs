namespace LibraryTerminal;

public class SearchEngine
{
    ListOfBooks BooksRef = new ListOfBooks();
    List<Book> books = new List<Book>();
    
    public string SearchTitle()
    {
        Console.WriteLine("Let's search by the name. Enter book name: ");
        string bookName = Console.ReadLine();
        bookName = bookName.ToLower().Trim();
        foreach (Book book in books)
        {
            if (bookName == book.Title)
            {
                return book.Title;
            } ;
        }
        return "No Book Found.";
        
    }
    
    public List<Book> SearchAuthor()
    {
        Console.WriteLine("Let's search by the author. Enter book author: ");
        string bookAuthor = Console.ReadLine();
        bookAuthor = bookAuthor.ToLower().Trim();
        bool DoesAuthorExist = false;
        
        foreach (Book book in BooksRef.books)
        {
            if (bookAuthor == book.Author.ToLower().Trim())
            {
                DoesAuthorExist = true;
                books.Add(book);
            } 
        }

        if (!DoesAuthorExist)
        {
            Console.WriteLine("Author not found in registry.");
            // When Setting be sure to make it so that if the property is null, make it false
            return null;
        }
        return books;
        
    }

    public Book CheckOutBook(String bookToBeChecked)
    {
        foreach (var book in books)
        {
            if (book.Title == bookToBeChecked)
            {
                return book;
            }
        }
        return null;
    }
    
}