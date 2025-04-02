namespace oopiInCsharp;

public class Employee
{
    public virtual void MakeHRRequest()
    {
        Console.WriteLine("Employee makes an HR request.");
    }
}

public class Manager : Employee
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Manager makes an HR request.");
    }

    public void MoveToOffice()
    {
        Console.WriteLine("Manager moves to office.");
    }
}

public class Engineer : Employee
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Engineer makes an HR request.");
    }
}