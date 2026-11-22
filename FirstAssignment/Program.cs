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

//void AddBonusPages(int pages)
//{
//    pages += 50;
//}
//int pages = 400;

//AddBonusPages(pages);

//Console.WriteLine(pages); // I expect to see 400 because the method does not modify the original variable, it only modifies a copy of it.which is treansfered 
// by value not by reference . Therefore, the original variable remains unchanged after the method call.  

#endregion
#region Question 6

//Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
//with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
//see, and why?

//void ApplyDiscount(double[] prices)
//{
//    prices[0] -= 5;
//}

//double[] prices = { 25.5, 40.0 };
//ApplyDiscount(prices);
//Console.WriteLine(prices[0]); // I expect to see 20.5 because the method modifies the original array, which is passed by reference. Therefore, the change made to prices[0] inside the method will be reflected in the original array after the method call.

#endregion

#region Question 7
//Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
//Call it and print pages afterward. How is the result different from question 5?
//void AddBonusPages(ref int pages)
//{
//    pages += 50;
//}
//int pages = 400;

//AddBonusPages(ref pages);

//Console.WriteLine(pages);// I expect to see 450 because the method modifies the original variable, which is passed by reference using the ref keyword. Therefore, the change made to pages inside the method will be reflected in the original variable after the method call.

#endregion


#region Question 8
//Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
//new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
//afterward.
//void ReplaceArray(ref double[] prices)
//{
//    prices = new double[] { 10.0, 12.5, 15.0 };
//}

//double[] prices = { 25.5, 40.0, 33.75 };

//ReplaceArray(ref prices);

//Console.WriteLine(prices.Length); // I expect to see 3 because the method replaces the original array with a new array of length 3. Therefore, after the method call, prices will refer to the new array, and its length will be 3.



#endregion


#region Question 9
//Write a method bool TryGetPrice(string title, out double price) that returns true and sets
//price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it
//and print the price if found

//bool TryGetPrice(string title, out double price)
//{
//    if (title == "Clean Code")
//    {
//        price = 25.5;
//        return true;
//    }
//    else
//    {
//        price = 0;
//        return false;
//    }
//}

//Console.WriteLine(TryGetPrice("Clean Code", out double price));




#endregion

#region Question 10
//Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
//it once with only a title, and once passing both a title and pages.
void PrintBookInfo(string title, int pages = 300)
{
    Console.WriteLine($"Title: {title}, Pages: {pages}");
}

PrintBookInfo("Clean Code");

PrintBookInfo("Clean Code", 352);


#endregion

#region Question 11

#endregion

#region Question 12



#endregion

