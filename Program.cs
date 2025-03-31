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