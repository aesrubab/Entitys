
namespace ConsoleApp21.Entitis;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<AuthorBook> AuthorBooks { get; set; }
}
