namespace LibraryTerminal;
/*
 * ● Your solution must include some kind of a book class with a title, author, status, and due
        date if checked out.
   o Status should be On Shelf or Checked Out (or other statuses you can imagine).
     -12 items minimum; All stored in the the application.
   ● Allow the user to:
   - Display the entire list of books. Format it nicely.
   - Search for a book by author.
   - Search for a book by title keyword.
   - Select a book from the list to check out.
   - If it’s already checked out, let them know.
   - If not, check it out to them and set the due date to 2 weeks from today.
   - Return a book. (You can decide how that looks/what questions it asks.)
   Optional enhancement:
   - When the user quits, save the current library book list (including due dates and statuses)
   to the text file so the next time the program runs, it remembers.
 */
class Program
{
     
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        
        ListOfBooks BooksRef = new ListOfBooks();
        bool userWantsToExit = false;
        Dictionary<int,string> terminalOptions = new Dictionary<int,string>();
        
        terminalOptions.Add(1,"Search by Book Title");
        terminalOptions.Add(2,"Search by Author");
        terminalOptions.Add(3,"Show All Books");
        terminalOptions.Add(4,"Exit Terminal");
        
        while (!userWantsToExit)
        {
            Console.WriteLine("*");
            Console.WriteLine("The Current Date is " + currentDate);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome to the Library Terminal, Please select an option by number below:");
            Console.WriteLine("1. Search by Book Title");
            Console.WriteLine("2. Search by Author");
            Console.WriteLine("3. Show All Books");
            Console.WriteLine("4. Exit Terminal");

            bool validInput = false;
            int userInput = 0;
            while (!validInput){
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput > 4)
                    {
                        Console.WriteLine("Please enter a valid number");
                        validInput = false;
                        continue;
                    }
                    validInput = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                    validInput = false;
                }
            }

            switch (userInput)
            {
                case 1:
                    SearchEngine SearchTitle = new SearchEngine();
                    List<Book> bookTitleList = SearchTitle.SearchTitle();
                    if (bookTitleList == null){ continue;}
                    
                    Console.WriteLine("\nAll Books Found: ");
                    foreach (Book book in bookTitleList)
                    {
                        Console.WriteLine(book.Title);
                    }
                    
                    Console.WriteLine("\nPlease Select the Book you would like to check out");
                    CheckOutBookProcess(SearchTitle);
                    
                    break;
                case 2:
                    SearchEngine SeachRef = new SearchEngine();
                    List<Book> booklist = SeachRef.SearchAuthor();
                    if (booklist == null){continue;}
                    
                    Console.WriteLine("\n All entries found:");
                    foreach (Book book in booklist)
                    {
                        Console.WriteLine(book.Title);
                    }
                    Console.WriteLine("\n Please Select the Book you would like to check out");
                    CheckOutBookProcess(SeachRef);
                    
                    break;
                case 3:
                    Console.WriteLine("\nList of All Books Found: ");
                    for (int i = 0; i < BooksRef.books.Count; i++)
                    {
                        Console.WriteLine(BooksRef.books[i].Title);
                    }
                    break;
                case 4:
                    userWantsToExit = true;
                    Console.WriteLine("Please visit again!");
                    break;
            }
        }

    }

    static void CheckOutBookProcess(SearchEngine SearchRef)
    {
        string userDecision = Console.ReadLine();
        bool bookvalid = false;
        foreach (Book book in SearchRef.books)
        {
            if (book.Title == userDecision)
            {
                bookvalid = true;
                break;
            }
        }

        if (!bookvalid)
        {
            Console.WriteLine("Please enter a valid book title");
            return;
        }

        Book bookCheckedOut = SearchRef.CheckOutBook(userDecision);
        if (bookCheckedOut.IsCheckedOut == true)
        {
            Console.WriteLine("\nBook Checked-Out :(");
            return;
        }
        Console.WriteLine("\nThank you for checking out " + bookCheckedOut.Title);
        string BookDueDate = DateTime.Now.AddDays(14).Date.ToString("MM/dd/yyyy");
        Console.WriteLine("The book will be due for return on " + BookDueDate);
    }
    
    static string IntDateToStringDate(int date)
    {
        string dateString = date.ToString();
        
        string month = dateString.Substring(0, 2);
        string day = dateString.Substring(1,2);
        string year = dateString.Substring(4);
        
        return (month + "/" + day + "/" +  year);
    }
    
}