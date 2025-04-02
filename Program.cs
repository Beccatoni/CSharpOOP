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

// another example
Manager manager1 = new Manager();
manager1.MakeHRRequest();
Engineer engineer1 = new Engineer();
engineer1.MakeHRRequest();


// upcasting 
//create a Dog Object
Dog myDog1 = new Dog();
// Upcast the Dog object to an animal refernce
Animal myAnimal = myDog;
myAnimal.MakeSound();// outputs Dog barks.
myAnimal.Walk(); // outputs: Animal walks.
// myAnimal.Sleep(); // outputs: Error

//upcasting employee class
Employee myEmployeeManager = manager1;
myEmployeeManager.MakeHRRequest();

// downcasting
Dog myDog2 = (Dog)myAnimal;
myDog2.MakeSound();
myDog2.Walk();
myDog2.Sleep();

Manager manager2 = (Manager)myEmployeeManager;
manager2.MoveToOffice();

// is operator
if (myAnimal is Dog)
{
    Console.WriteLine("This is a Dog.");
}

if (myAnimal is Cat)
{
    Console.WriteLine("This is a cat.");
}
else
{
    Console.WriteLine("This is not a Cat.");
}

Employee myEmployee = new Engineer();
Console.WriteLine(myEmployee is Engineer);
Console.WriteLine(myEmployee is Manager);

// as operators
Employee myEmployeeEngineer1 = new Engineer();
Employee myEmployeeEngineer2 = new Engineer();

Engineer engineer = myEmployeeEngineer1 as Engineer;
Console.WriteLine(engineer == null);
Manager manager = myEmployeeEngineer2 as Manager;
Console.WriteLine(manager == null);