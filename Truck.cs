namespace oopiInCsharp;

public class Truck: Vehicle
{
    public double Weight { get; }

    public Truck(double speed, double weight) : base(speed)
    {
        Weight = weight;
        // (weight < 400) ? Wheels = 8: Wheels = 12;
        if (weight < 400)
        {
            Wheels = 8;
        }
        else
        {
            Wheels = 12;
        }
    }
}