#region Question 1
//using System.Reflection;

//Book book1 = new Book {
//    title="The Great Gatsby",
//    pages=180
//};

//object book2 = new Book
//{
//    title = "1984",
//    pages = 328
//};
//Console.WriteLine($"Book 1: {book1.title}, Pages: {book1.pages}");
//Console.WriteLine($"Book 2: {((Book)book2).title}, Pages: {((Book)book2).pages}"); //I experminted a little found type casting here works
//class Book
//{
//    public required string title;
//    public int pages;
//};
#endregion

#region Question2 
object book1 = new Book
{
    title = "My harsh road to become a Full-Stack Developer",
    pages = 328
};

Console.WriteLine(typeof(Book));
Console.WriteLine(book1.Equals(book1));
Console.WriteLine(book1.GetHashCode());
Console.WriteLine("equivalent to string is " + book1.ToString());
Console.WriteLine(book1.GetType());

class Book
{
    public required string title;
    public int pages;
};

#endregion
