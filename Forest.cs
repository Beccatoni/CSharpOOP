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

    static Forest()
    {
        forestFacts = $"Forests provide a diversity of ecosystem services including:\n\taiding in regulating climate.\n\tpurifying water.\n\tmitigating natural hazards such as floods.\n";
        ForestsCreated = 0;
    }

    public static int ForestsCreated
    {
        get;
        private set;
    }
    public static string forestFacts;

    private static string ForestFacts
    {
        get
        {
            return forestFacts;
        }
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

    public static void PrintForestFacts()
    {
        Console.WriteLine(ForestFacts);
    }
    
}