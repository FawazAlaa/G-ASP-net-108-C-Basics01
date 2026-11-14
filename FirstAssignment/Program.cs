#region Question 1
using System.Reflection;

Book book1 = new Book {
    title="The Great Gatsby",
    pages=180
};

object book2 = new Book
{
    title = "1984",
    pages = 328
};
Console.WriteLine($"Book 1: {book1.title}, Pages: {book1.pages}");
Console.WriteLine($"Book 2: {((Book)book2).title}, Pages: {((Book)book2).pages}"); //I experminted a little found type casting here works
class Book
{
    public required string title;
    public int pages;
};


#endregion
