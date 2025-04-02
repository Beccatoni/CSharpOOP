// See https://aka.ms/new-console-template for more information

using oopiInCsharp;

Console.WriteLine("Hello, World!");
// Forest f = new Forest {name="Amazon", biome = "Rain forest", trees = 342, age = 200};
var f = new Forest("Amazon");
Console.WriteLine(f.trees);
f.Grow();
Console.WriteLine(f.trees);

var sun = new Star("Sun", "G-type");
sun.Shine();
sun.GrowOlder();
sun.Shine();
sun.Supernova();

var unknownStar = new Star("Mystery Star");
unknownStar.Shine();
unknownStar.GrowOlder();

Forest.PrintForestFacts();

Console.WriteLine(Forest.ForestsCreated);
Forest f1 = new Forest("Gishwati");
Forest f2 = new Forest("Nyungwe", "Rain forest");
Console.WriteLine(Forest.ForestsCreated);

Profile p1 = new Profile("Sam Drakkila", 30, "New york", "USA", "he/him");
Console.WriteLine(p1.ViewProfile());
p1.SetHobbies(new string[]{"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel","reading advice columns"});


Sedan s = new Sedan(60);
Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h");
s.SpeedUp();
Console.WriteLine($"Sedan's faster speed: {s.Speed}");

Truck t = new Truck(45, 500);
Console.WriteLine($"Truck with license plate {t.LicensePlate} and {t.Wheels}, driving at {t.Speed}km/h.");
t.SpeedUp();
Console.WriteLine($"Truck's faster speed: {t.Speed}");

// Bicycle b = new Bicycle(10);
// Console.WriteLine($"Bicycle with {b.Wheels} wheels, driving at {b.Speed} km/h.");
// b.SpeedUp();
// Console.WriteLine($"Bicycle's faster speed: {b.Speed}");

//polymorphism in action
Animal myDog = new Dog();
Animal myCat = new Cat();
myDog.MakeSound();
myCat.MakeSound();