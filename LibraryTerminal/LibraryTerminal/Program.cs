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
        Console.WriteLine("Hello, World!");
    }
}