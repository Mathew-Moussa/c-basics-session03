#region q1
using System.ComponentModel.Design;
using System.Text;

{
    string title = "clean code";
    Console.WriteLine(title);
    string upperTitle = title.ToUpper();
    Console.WriteLine(upperTitle);
}
#endregion
#region q2
{
    Console.WriteLine("---------------------------------");
    string title = "clean code";
    string title2 = "clean code";
    Console.WriteLine(ReferenceEquals(title, title2));
}
#endregion
#region q3,q4
{
    //3
    Console.WriteLine("---------------------------------");
    StringBuilder title = new StringBuilder();
    title.Append("Book List");
    title.Append("- Updated");
    Console.WriteLine(title);
    //4
    Console.WriteLine("---------------------------------");
    title.Replace("Book List", "Library");
    Console.WriteLine(title);
}
#endregion
#region q5,q6,q7
{
    string title = "clean code";
    int pages = 464;
    //5
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Book: " + title + ",Pages: " + pages);
    //6
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Book: {title},Pages: {pages}");
    //7
    Console.WriteLine("---------------------------------");
    Console.WriteLine(string.Format("Book: {0},Pages: {1}",title,pages));
}
#endregion
#region q8
{
    Console.WriteLine("---------------------------------");
    int pages = 464;
    if (pages > 300)
        Console.WriteLine("long book");
    else
        Console.WriteLine("short book");
    
}
#endregion 
#region q9
{
    Console.WriteLine("---------------------------------");
    int pages = 464;
    bool isAvailable = true;
    if (pages > 300 && isAvailable == true)
        Console.WriteLine("You can borrow this book");
    else
        Console.WriteLine("Not Available ");

}
#endregion 
#region q10
{
    Console.WriteLine("---------------------------------");
    string title = "Refactoring";

    switch (title)
    {
        case "Clean Code":
            Console.WriteLine("Great choice!");
            break;
        case "Refactoring":
            Console.WriteLine("Nice pick!");
            break;
        default:
            Console.WriteLine("Never heard of it");
            break;
    }
}
#endregion
#region q11
{
    Console.WriteLine("---------------------------------");
    int pages = 464;
    string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
    Console.WriteLine(sizeLabel);
}
#endregion
#region q12,13,15,16,17,18
{
    string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
    //12
    Console.WriteLine("---------------------------------");
    for (int i = 0; i < books.Length; i++) {
        Console.WriteLine($"{i + 1}. {books[i]}");
    }
    //13
    Console.WriteLine("---------------------------------");
    int j=0;
    while(j < books.Length)
    {
        Console.WriteLine($"{j + 1}. {books[j]}");
        j++;
    }
    //15
    Console.WriteLine("---------------------------------");
    foreach (string book in books) 
        { Console.WriteLine(book); }
    //16
    Console.WriteLine("---------------------------------");
    foreach (string book in books)
    { if (book == "Refactoring")
          break;
      else
        Console.WriteLine(book); }
    //17
    Console.WriteLine("---------------------------------");
    foreach (string book in books)
    {
        if (book == "The Pragmatic Programmer")
            continue;
        else
            Console.WriteLine(book);
    }
    //18
    Console.WriteLine("---------------------------------");
    void PrintFirstBook(string[] books)
    {
        if (books.Length == 0)
        {
            return;   
        }

        Console.WriteLine(books[0]);
    }
    PrintFirstBook(books);
    
}
#endregion
#region q14
{
    Console.WriteLine("---------------------------------");
    int i = 0;
    do {
        Console.WriteLine("Checking book...");
        i++;
        } while (i < 3);
}
#endregion



