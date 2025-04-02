namespace oopiInCsharp;

public interface IAutomobile
{
    string LicensePlate { get;}
    double Speed { get; }
    int Wheels { get; }
    void Honk();
}