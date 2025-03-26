// See https://aka.ms/new-console-template for more information

using oopiInCsharp;

Console.WriteLine("Hello, World!");
// Forest f = new Forest {name="Amazon", biome = "Rain forest", trees = 342, age = 200};
Forest f = new Forest("Amazon");
Console.WriteLine(f.trees);
f.Grow();
Console.WriteLine(f.trees);