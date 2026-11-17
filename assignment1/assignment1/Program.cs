#region Q1
{
    object book = new Book { Title = "book1", Pages = 122 };
    Console.WriteLine(book);
}
#endregion

#region Q2
{
    object book = new Book { Title = "book2", Pages = 123 };
    Console.WriteLine(book.ToString());
    Console.WriteLine(book.Equals(book));
    Console.WriteLine(book.GetHashCode());
    Console.WriteLine(book.GetType());
}
#endregion

#region Q3 
{
    // int pages = "464"; Compile-time error 
    int pages = int.Parse("464");
    Console.WriteLine(pages);
}
#endregion

#region Q4
{
    try
    {
        int zero = 0;
        int result = 10 / zero;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    finally
    {
        Console.WriteLine("Done");
    }
}
#endregion

#region Q5
{
    int pages = 300;
    double d = pages;
    Console.WriteLine(d);
}
#endregion

#region Q6
{
    double price = 49.99;
    int p = (int)price;
    Console.WriteLine(p);  
}
#endregion

#region Q7
{
    string pagesText = "464";
    int pages = Convert.ToInt32(pagesText);
    Console.WriteLine(pages);
}
#endregion

#region Q8
{
    string yearText = "2023";
    int year = int.Parse(yearText);
    Console.WriteLine(year);

    string badText = "abc";
    bool cond= int.TryParse(badText, out int result);
    if (cond==false)
    {
        Console.WriteLine("Invalid number");
    }
}
#endregion

#region Q9
{
    int pages = 464;
    string s = pages.ToString();
    Console.WriteLine(s.GetType());
}
#endregion

#region Q10
{
    int copies = 100;
    object boxed = copies;
    int unboxed = (int)boxed;
    Console.WriteLine(boxed);
    Console.WriteLine(unboxed);
}
#endregion

#region Book class
class Book
{
    public string Title;
    public int Pages;
}
#endregion