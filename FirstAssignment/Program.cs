#region Question 1
//Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
//both title and upperTitle to show that title did not change.

//string title = "clean code";
//string upperTitle = title.ToUpper();

//Console.WriteLine(title);
//Console.WriteLine(upperTitle);

#endregion

#region Question2 
//Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
//to check if they point to the same object in memory.

//string var01 = "Clean Code";
//string var02 = "Clean Code";

//bool areSame = ReferenceEquals(var01, var02);
//Console.WriteLine(areSame);

#endregion

#region Question 3
//Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
//object. Print the final result.

//using System.Text;
//StringBuilder sb = new StringBuilder();
//sb.Append("Book List");
//sb.Append(" - Updated");
//Console.WriteLine(sb.ToString());
#endregion
#region Question 4
//Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
//Print the result.
using System.Text;
StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - Updated");
sb.Replace("Book List", "Library");
Console.WriteLine(sb.ToString());

#endregion

#region Question 5

#endregion
#region Question 6

#endregion

#region Question 7

#endregion


#region Question 8


#endregion



#region Question 9


#endregion

#region Question 10


#endregion

#region Question 11

#endregion

#region Question 12

#endregion

#region Question 13


#endregion

#region Question 14

#endregion

#region Question 15


#endregion