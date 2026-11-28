#region Question 1
//public struct DeliveryAddress
//{
//    public string City;
//    public string Street;
//}
//public class Customer
//{
//    public string Name;
//}

//Consider the following code:
//a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
//When a DeliveryAddress struct variable is copied into another variable, a separate copy of its value is created. Modifying the copy does not affect the original variable.
//b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
//here is it modified because as it is a ref value it takes the ref where it is created Therefore, modifying the object's properties through either variable affects the same object
//, and the changes are visible through both variables.

#endregion
#region Question2 
//public class Shipment
//{
//    public string Description;
//    public double Weight;
//    public decimal DeliveryFee;
//}
//a) Identify at least three problems with this design from an encapsulation perspective.
//1.No restriction on direct access to internal state
//2.No controlled access through properties (getters/setters) 
//3. No validation or protection of business rules anything can be null or zero 
//b) How can private fields and public properties improve this design ?
//Private fields and public properties improve encapsulation by preventing direct access to an object's internal state. Public properties provide controlled access through getters and setters,
//allowing validation of values and restricting modifications when necessary meaning will ssolve all porblems wrote in A


#endregion
#region Question 3


DeliveryAddress newAddress = new DeliveryAddress("Alexnadria", "2034", 4);

DeliveryAddress newAddress01 = newAddress;
newAddress01.city = "Cairo";
newAddress01.street = "2000";
newAddress01.BuildingNumber = 1;

Console.WriteLine(newAddress);
Console.WriteLine( "Well cairo one is " + newAddress01);
public struct DeliveryAddress
{
    public string city;
    public string street;
    public int BuildingNumber;


    public DeliveryAddress(string city, string street, int BuildingNumber)
    {
        this.city = city;
        this.street = street;
        this.BuildingNumber = BuildingNumber;
    }

    public override string ToString()
    {
        return $"FullAddress:{city} {street} {BuildingNumber}";
    }
}

#endregion
#region Question 4
//Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
//assign it Genre.Science, and print it.
//Console.WriteLine(book01.property); //enum declared in the User.Shared

#endregion
#region Question 5
//Console.WriteLine((int)Genre.Fiction);
//Console.WriteLine((int)Genre.NonFiction);
//Console.WriteLine((int)Genre.Science);



#endregion
#region Question 6
//Given int genreNumber = 1;, cast it into a Genre value and print the result.
//int genreNumber = 1;
//Genre genre = (Genre)genreNumber;
//Console.WriteLine(genre);

#endregion

#region Question 7
//Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
//Genre genre = Genre.Fiction;
//Console.WriteLine(genre.ToString());

#endregion


#region Question 8
//Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
//print the result.
//string genreText = "Science";

//Console.WriteLine( Enum.Parse<Genre>(genreText));

#endregion


#region Question 9
//Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
//attempt the conversion. Print "Unknown genre" if it fails.
//string genreText = "Mystery";

//bool isValid = Enum.TryParse<Genre>(genreText, out Genre genre);

//if (isValid)
//{
//    Console.WriteLine(genre);
//}
//else
//{
//    Console.WriteLine("Unknown genre");
//}

#endregion



