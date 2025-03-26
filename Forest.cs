namespace oopiInCsharp;

public class Forest
{
    public string name;
    public string biome;
    public int trees;
    public int age;

    public Forest(string name, string biome)
    {
        this.name = name;
        this.biome = biome;
        age = 1;
    }

    public Forest(string name) : this(name, "Unknown")
    {
        Console.WriteLine("No biome provided, using default value \"Unknown\".");
    }
    
    public int Grow()
    {
        trees += 30;
        age += 1;
        return trees;
    }

    public int Burn()
    {
        trees -= 20;
        age += 1;
        return trees;
    }
}