namespace LibraryTerminal;

public class ListOfBooks
{
    public List<Book> books = new List<Book>()
    {
        new Book("To Killa Mockingbird", "Harper Lee", isCheckedOut: true, dueDate:101825),
        new Book("Pride and Prejudice", "Jane Austen", isCheckedOut: false, dueDate: 0),
        new Book("Philosopher's Stone", "J.K Rowling", isCheckedOut: true, dueDate:061525),
        new Book("Chamber of Secrets", "J.K Rowling", isCheckedOut: false, dueDate:0),
        new Book("Prisoner of Azkaban", "J.K Rowling", isCheckedOut: false, dueDate:0),
        new Book("Goblet of Fire", "J.K Rowling", isCheckedOut: true, dueDate:061825),
        new Book("Order of the Phoenix", "J.K Rowling", isCheckedOut: false, dueDate:0),
        new Book("Half-Blood Price", "J.K Rowling", isCheckedOut: false, dueDate:0),
        new Book("Deathly Hallows", "J.K Rowling", isCheckedOut: false, dueDate:0),
        new Book("Lord of the Rings", "J.R.R. Tolkien", isCheckedOut: true, dueDate:060325),
        new Book("The Handmaid's Tale", "Margaret Atwood", isCheckedOut: false, dueDate:0),
        new Book("Amazing Spider-Man", "Nick Spencer", isCheckedOut: false, dueDate:0)

    };
}