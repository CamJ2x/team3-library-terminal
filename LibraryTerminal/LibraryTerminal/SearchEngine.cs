namespace LibraryTerminal;

public class SearchEngine
{
    ListOfBooks BooksRef = new ListOfBooks();
    public List<Book> books = new List<Book>();
    
    public List<Book> SearchTitle()
    {
        Console.WriteLine("Let's search by the name. Enter book name: ");
        string bookName = Console.ReadLine();
        bookName = bookName.ToLower().Trim();
        bool DoesTitleExist = false;
        string WantedBook = " ";
        
        
        foreach (Book book in BooksRef.books)
        {
            if (book.Title.ToLower().Contains(bookName))
            {
                DoesTitleExist = true;
                books.Add(book);
                //WantedBook = book.Title;
            } ;
        }

        if (!DoesTitleExist)
        {
            Console.WriteLine("That book is not found in registry .");
            return null;
        }

        return books;

    }
    
    public List<Book> SearchAuthor()
    {
        List<String> Authors = new List<string>();
        Console.WriteLine("All book authors in library: :");
        foreach (Book book in BooksRef.books)
        {
            string author = book.Author;
            if (!Authors.Contains(author))
            {
                Authors.Add(author);
                Console.WriteLine(author);
            }
        }
        
        Console.WriteLine("\nLet's search by the author. Enter book author: ");
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