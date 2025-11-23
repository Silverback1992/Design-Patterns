using SimpleFactory;

//There are different approaches to simple factory, but all fall under this design principle

//1. Having a concrecte class creating a concrete class
var pwFactory = new PasswordFactory();

//2. Concrete class itself having a create method with a private constructor
var product = Product.Create();

//3. Concrete factory class returning an abstraction of a class
var dog = AnimalShelter.GetPet(0);
var cat = AnimalShelter.GetPet(1);

Console.WriteLine("Done");
