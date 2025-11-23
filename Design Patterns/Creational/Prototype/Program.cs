using Prototype;

//Shallow Copy
var person = new Person("Peti", ["Programming"]);

var shallowCopy = person.ShallowClone();
var deepCopy = person.DeepClone();

shallowCopy.Hobbies.Add("CS2");
deepCopy.Hobbies.Add("Mentoring");

person.Hobbies.ForEach(Console.WriteLine);

//Canvas
var rectangle = new Rectangle(100, 100, Color.LightGray);
var rectangleClone = (Rectangle)rectangle.Clone();

rectangleClone.Color.Red = 100;
rectangleClone.Color.Green = 100;
rectangleClone.Color.Blue = 100;

var circle = new Circle(10, Color.LightGray);
var circleClone = (Circle)circle.Clone();

circleClone.Color.Red = 5;
circleClone.Color.Green = 5;
circleClone.Color.Blue = 5;


Console.WriteLine("hello");
