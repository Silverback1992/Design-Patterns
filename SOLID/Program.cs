using HelperLibrary.Open_Closed_Principle_helper;
using SOLID.D;
using SOLID.D.Interfaces;
using SOLID.L;
using SOLID.L.Shapes;
using SOLID.O;
using SOLID.O.Enums;
using SOLID.O.Filters;
using SOLID.O.Specifications;
using SOLID.S;
using System.Diagnostics;

//SOLID

//1.) S: Single Responsibility Principle
#region S: Single Responsibility Principle
Console.WriteLine("Single Responsibility Principle test:\n");

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

//2.) O: Open-Closed Principle
#region O: Open-Closed Principle
Console.WriteLine("\nOpen-Closed Principle test:\n");

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
Console.WriteLine("Large products:\n");
foreach (var product in BadProductFilter.FilterBySize(products, Size.Large))
    Console.WriteLine($" - {product.Name} is large");

//Better way
Console.WriteLine("\nLarge products:\n");
foreach (var product in products.FilterProduct(new SizeSpecification(Size.Large)))
    Console.WriteLine($" - {product.Name} is large");

#endregion O: Open-Closed Principle

//3.) L: Liskov Substitution Principle
#region L: Liskov Substitution Principle
Console.WriteLine("\nLiskov Substitution Principle test:\n");

//So far so good...
Console.WriteLine("This can still work:\n");
BadRectangle rc = new BadRectangle(2, 3);
Console.WriteLine($"{rc} has area {RectanglePropertyCalculator.Area(rc)}");

BadSquare sq = new BadSquare();
sq.Width = 4;
Console.WriteLine($"{sq} has area {RectanglePropertyCalculator.Area(rc)}");

//Because a square is a rectangle however you should be able to create it like this as well:
Console.WriteLine("\nHowever here we are going off road:\n");
BadRectangle rc2 = new BadRectangle(2, 3);
Console.WriteLine($"{rc2} has area {RectanglePropertyCalculator.Area(rc2)}");

BadRectangle sq2 = new BadSquare();
sq2.Width = 4;
Console.WriteLine($"{sq2} has area {RectanglePropertyCalculator.Area(sq2)}");
//This is where we are violating the Liskov Substitution Principle because we are unable to create a square object with rectangle type
//with the same functionality - it is basically working incorrectly

//So instead we are creating properties as virtual and overriding them:
Console.WriteLine("\nCorrect way:\n");

Rectangle rcCorrect = new Rectangle(2, 3);
Console.WriteLine($"{rcCorrect} has area {RectanglePropertyCalculator.Area(rcCorrect)}");

Rectangle sqCorrect = new Square();
sqCorrect.Width = 4;
Console.WriteLine($"{sqCorrect} has area {RectanglePropertyCalculator.Area(sqCorrect)}");

#endregion L: Liskov Substitution Principle

//4.) I: Interface Segregation Principle
#region Interface Segregation Principle
//Nothing here, check the folder for code and explanation
#endregion Interface Segregation Principle

//5.) D: Dependency Inversion Principle
#region Dependency Inversion Principle
Console.WriteLine("\nDependency Inversion Principle test:\n");

var parent = new Person { Name = "John" };
var child1 = new Person { Name = "Chris" };
var child2 = new Person { Name = "Mary" };

var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);

Console.WriteLine("Old research:\n");

Research.DoResearch(relationships);

//The problem here is that we Relationships is exposing a private field that is used by Research
//As a result Relationships class can't change its mind on how to store the values

//But by making the necessary changes (check the interfaces and better version we can reproducre the same result
//without violating the Dependency Inversion principle

var relationshipsBetter = new RelationshipsBetter();
relationshipsBetter.AddParentAndChild(parent, child1);
relationshipsBetter.AddParentAndChild(parent, child2);

Console.WriteLine("\nNew research:\n");

Research.DoBetterResearch(relationshipsBetter);

#endregion Dependency Inversion Principle