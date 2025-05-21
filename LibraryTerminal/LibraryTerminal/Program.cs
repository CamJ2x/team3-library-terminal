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
        int currentDate = 122025;
        string date = IntDateToStringDate(currentDate);
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
            Console.WriteLine("The Current Date is " + date);
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
                    Console.WriteLine("Search by Book Title");
                    return;
                case 2:
                    Console.WriteLine("Search by Author");
                    return;
                case 3:
                    for (int i = 0; i < BooksRef.books.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {BooksRef.books[i].Title}");
                    }
                    break;
                case 4:
                    userWantsToExit = true;
                    Console.WriteLine("Please visit again!");
                    break;
            }
        }

    }

    static bool validInput(int input, int limit)
    {
        
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