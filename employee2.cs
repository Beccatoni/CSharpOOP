namespace oopiInCsharp;

abstract class Employee2
{
    public abstract void MakeHRRequest();

    // public void Promotion()
    // {
    //     Console.WriteLine("Promotion of HR.");
    // }

    public void ClockIn()
    {
        Console.WriteLine("Employee clocks in.");
    }
}

class Manager2 : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Making an HR request.");
    }

    public void Promotion()
    {
        Console.WriteLine("Manager gets a promotion.");
    }

    public void ConductMeeting()
    {
        Console.WriteLine("Manager conducts a team meeting.");
    }
}

class Engineer2 : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Engineer makes an HR request.");
    }

    public void Promotion()
    {
        Console.WriteLine("Engineer gets a promotion.");
    }

    public void SubmitPR()
    {
        Console.WriteLine("Engineer submits a pull request.");
    }
    
}

class Intern : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Intern makes an HR request.");
    }

    public void FetchCoffee()
    {
        Console.WriteLine("Intern fetches coffee for the team.");
    }
}

class HR : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("HR processes a HR request.");
    }

    public void OrganizeTraining()
    {
        Console.WriteLine("HR organizes a training session.");
    }
}

class Salesperson : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Salesperson makes an HR request.");
    }

    public void MakeSale()
    {
        Console.WriteLine("Salesperson makes a sale.");
    }
}

class Developer : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Developer makes an HR request.");
    }

    public void WriteCode()
    {
        Console.WriteLine("Developer writes code.");
    }

    public void FixBug()
    {
        Console.WriteLine("Developer fixes a bug.");
    }
}

class Designer : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("Designer makes an HR request.");
    }

    public void CreateDesign()
    {
        Console.WriteLine("Designer creates a new design.");
    }
}

class CEO : Employee2
{
    public override void MakeHRRequest()
    {
        Console.WriteLine("CEO makes an HR request.");
    }

    public void MakeDecision()
    {
        Console.WriteLine("CEO makes a critical business decision.");
    }
}