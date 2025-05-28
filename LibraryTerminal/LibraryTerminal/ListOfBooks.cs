namespace LibraryTerminal;

public class ListOfBooks
{
    public List<Book> books = new List<Book>()
    {
        new Book("To Kill a Mockingbird", "Harper Lee", isCheckedOut: true, new DateTime(2025, 06, 8)),
        new Book("Pride and Prejudice", "Jane Austen", isCheckedOut: false, new DateTime(2025, 06, 10)),
        new Book("Philosopher's Stone", "J.K Rowling", isCheckedOut: true, new DateTime(2025, 06, 11)),
        new Book("Chamber of Secrets", "J.K Rowling", isCheckedOut: false, new DateTime(2025, 06, 12)),
        new Book("Prisoner of Azkaban", "J.K Rowling", isCheckedOut: false, new DateTime(2025, 06, 13)),
        new Book("Goblet of Fire", "J.K Rowling", isCheckedOut: true, new DateTime(2025, 06, 14)),
        new Book("Order of the Phoenix", "J.K Rowling", isCheckedOut: false, new DateTime(2025, 06, 15)),
        new Book("Half-Blood Price", "J.K Rowling", isCheckedOut: false, new DateTime(2025, 06, 16)),
        new Book("Deathly Hallows", "J.K Rowling", isCheckedOut: false, new DateTime(2025, 06, 17)),
        new Book("Lord of the Rings", "J.R.R. Tolkien", isCheckedOut: true, new DateTime(2025, 06, 18)),
        new Book("The Handmaid's Tale", "Margaret Atwood", isCheckedOut: false, new DateTime(2025, 06, 19)),
        new Book("Amazing Spider-Man", "Nick Spencer", isCheckedOut: false, new DateTime(2025, 06,15))

    };
}