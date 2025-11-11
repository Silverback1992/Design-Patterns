using Decorator;

/*
The other way I could see myself implementing this is having different "services" or "handlers" that the different concrete components
can use. But if we have many of those services then we start to have problems of class explosion. 
*/

var marine2 = new Marine();
IInfantry marine3 = marine2;

IInfantry marine = new Marine();
Console.WriteLine($"Marine damage: {marine.Damage} Marine armor: {marine.Armor}");
marine = new ArmorUpgrade(new WeaponUpgrade(marine));
Console.WriteLine($"Marine damage: {marine.Damage} Marine armor: {marine.Armor}");
