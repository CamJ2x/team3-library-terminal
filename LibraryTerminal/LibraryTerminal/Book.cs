namespace LibraryTerminal;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsCheckedOut { get; set; }
    public int DueDate { get; set; } 

    public Book(string title, string author, bool isCheckedOut, int dueDate)
    {
        Title = title;
        Author = author;
        IsCheckedOut = isCheckedOut;
        DueDate = dueDate;
    }
    
    
    
    
    
    
    
}



    