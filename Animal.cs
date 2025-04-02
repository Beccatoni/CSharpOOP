using Console = System.Console;

namespace oopiInCsharp;

public class Animal
{
    public void Walk()
    {
        Console.WriteLine("Animal walks.");
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }

}

public class Dog : Animal
{
    public void Sleep()
    {
        Console.WriteLine("Dog sleeps.");
    }
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}