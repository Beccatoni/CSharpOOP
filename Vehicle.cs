namespace oopiInCsharp;

public class Vehicle
{
    public string LicensePlate { get; private set; }
    public double Speed { get; protected set; }
    public int Wheels { get; protected set; }

    public Vehicle(double speed)
    {
        Speed = speed;
        LicensePlate = Tools.GenerateLicensePlate();
    }

    public virtual void SpeedUp()
    {
        Speed += 5;
    }

    public virtual void SpeedDown()
    {
        Speed -= 5;
    }

    public void Honk()
    {
        Console.WriteLine("Honk!");
    }
}