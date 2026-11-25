#region Question 1
//Add a private string password = "secret"; field to a Book class. Try to print it from Main
//(outside the class). What happens, and why?

using User.Shared;

Book book01 = new Book();

//book01.Name = "Star";

//Console.WriteLine(book01.Name);
//Console.WriteLine(book01.password);//'Book' does not contain a definition for 'password' and no accessible extension method
//'password' accepting a first argument of type 'Book' could be found (are you missing a using directive or an assembly reference?)
//because the access modifier at private  which is only available within the containing class




#endregion
#region Question2 

//Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
//Why ?
//Console.WriteLine(book01.copiesInStock);
//No doesnty compile because access modifier is internal which is only used inside the same project


#endregion
#region Question 3
//Add a public string Title; field to Book.Set it and print it from Main.
//book01.Title = "Clean Code";
//Console.WriteLine(book01.Title);

#endregion
#region Question 4
//Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
//assign it Genre.Science, and print it.
//Console.WriteLine(book01.property); //enum declared in the User.Shared

#endregion
#region Question 5
Console.WriteLine((int)Genre.Fiction);
Console.WriteLine((int)Genre.NonFiction);
Console.WriteLine((int)Genre.Science);



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

