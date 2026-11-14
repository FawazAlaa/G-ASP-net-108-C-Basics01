#region Question 1
//Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
//variable of type object. Print it.

//Book book1 = new Book
//{
//    title = "The Great Gatsby",
//    pages = 180
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
//Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
//itself), GetHashCode(), and GetType() on book.

//object book1 = new Book
//{
//    title = "My harsh road to become a Full-Stack Developer",
//    pages = 328
//};

//Console.WriteLine(typeof(Book));
//Console.WriteLine(book1.Equals(book1));
//Console.WriteLine(book1.GetHashCode());
//Console.WriteLine("equivalent to string is " + book1.ToString());
//Console.WriteLine(book1.GetType());

//class Book
//{
//    public required string title;
//    public int pages;
//};

#endregion

#region Question 3
//Q03.Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
//int pages = "464";

//int pages = "464"; //This is a compile-time error 
//int pages = int.Parse("464"); //This is the fix for the compile-time error // or can use .tryparse() if true then prinmt
//pages = Convert.ToInt32("464");

#endregion
#region Question 4
//Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
//zero", and then prints "Done" in a finally block.
//try
//{
//Console.WriteLine((10 / 0));

//}
//catch (DivideByZeroException)  
//{
//    Console.WriteLine("Cannot divide by zero");
//}
//finally
//{
//    Console.WriteLine("Done");
//}

#endregion

#region Question 5
//Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
//hna da type of conversion asmha implicit conversion 
//int pages = 300;
//double pagesDouble = pages; 
#endregion
#region Question 6
//Declare a double price = 49.99; then convert it into an int using a cast.
//double price = 49.99;
//int priceInt = (int)price;
#endregion

#region Question 7
//Q07.Given string pagesText = "464";, convert it into an int using the Convert class.
//string pagesText = "464";
//int pagesInt = Convert.ToInt32(pagesText);
#endregion


#region Question 8
//Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
//use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

//string yearText = "2023";
//int yearInt = int.Parse(yearText);

//string badText = "abc";
//bool isValid = int.TryParse(badText, out int badInt);
//if (!isValid)
//{
//    Console.WriteLine("Invalid number");
//}

#endregion



#region Question 9
//Q09.Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
//to prove it's now a string.

//   int pages = 464;
//string pagesText = pages.ToString();
//Console.WriteLine(pagesText.GetType());

#endregion

#region Question 10
//Q10.Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
//variable, and print both.

//int copies = 100;
//object boxedCopies = copies; //Boxing

//int copiesUnbox=(int)boxedCopies; //Unboxing
//Console.WriteLine(copies);
//Console.WriteLine(copiesUnbox);

#endregion

#region Question 11
//Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
//int? year = null;
//Console.WriteLine(year.HasValue);
//year = 2023;
//Console.WriteLine(year);
#endregion

#region Question 12
//Q12.Declare a string? reviewer = null;. Print whether it is null
//string? reviewer = null;
//Console.WriteLine(reviewer == null);
#endregion

#region Question 13
//Q13.Declare a Book? book = null;. Use?.to safely read book.Title without crashing the program, and
//print the result.
//hna do i reuse the book class again or make a type ?
Book? book = null;

Console.WriteLine(book?.title);

class Book
{
    public required string title;
    public int pages;
};


#endregion

#region Question 14

#endregion

#region Question 15

#endregion