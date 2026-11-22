#region Question 1
//Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
//the second price (index 1).

//double[] prices = { 25.5, 40.0, 33.75 };
//Console.WriteLine(prices[1]);

#endregion

#region Question2 
//Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
//shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
//int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
//Console.WriteLine(shelfCopies[1, 0]);   
#endregion

#region Question 3
//Write a method called PrintWelcomeMessage that takes no parameters and prints
//"Welcome to the Library!". Call it from Main.

//void printWelcomeMessage()
//{
//    Console.WriteLine("Welcome to the Library!");
//}

//printWelcomeMessage();

#endregion
#region Question 4
//Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
//"Clean Code
//void PrintBookTitle(string title)
//{
//    Console.WriteLine("Book title: " + title);
//}

//string title = "Clean Code";
//PrintBookTitle(title);


#endregion

#region Question 5
//Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
//int pages = 400; and print pages afterward. What do you expect to see, and why?

void AddBonusPages(int pages)
{
    pages += 50;
}
int pages = 400;

AddBonusPages(pages);

Console.WriteLine(pages); // I expect to see 400 because the method does not modify the original variable, it only modifies a copy of it.which is treansfered 
                          // by value not by reference . Therefore, the original variable remains unchanged after the method call.  

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

