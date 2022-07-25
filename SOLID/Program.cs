using SOLID.O;
using SOLID.O.Enums;
using SOLID.O.Filters;
using SOLID.S;
using System.Diagnostics;

//SOLID

//1.) S: Single Responsibility Principle
#region S: Single Responsibility Principle
Console.WriteLine("Single Responsibility Principle test:" + Environment.NewLine);

var j = new Journal();
j.AddEntry("I cried today");
j.AddEntry("I ate a bug");

Console.WriteLine(j);

string fileName = @"E:\Programming\temp\journal.txt";
Persistence.SaveToFile(j, fileName, true);

var p = new Process();
p.StartInfo.FileName = fileName;
p.StartInfo.UseShellExecute = true;
p.Start();
#endregion S: Single Responsibility Principle

//2.) O: Open-closed principle
#region O: Open-closed Principle
Console.WriteLine(Environment.NewLine + "Open-closed Principle test:" + Environment.NewLine);

var products = new List<Product>()
{
    new Product("Apple", Color.Green, Size.Small),
    new Product("Tree", Color.Green, Size.Large),
    new Product("House", Color.Blue, Size.Large)
};

//The old way
//Here we can't see it but if we go into BadProductFilter then we can see that the problem is is that
//we keep modifying our ProductFilter class to add new functionalities to it that is pretty common occourence
//And with that we are violiting the open closed principle
Console.WriteLine("Large products:");
foreach (var product in BadProductFilter.FilterBySize(products, Size.Large))
    Console.WriteLine($" - {product.Name} is large");
    
//Better way


#endregion O: Open-closed Principle
