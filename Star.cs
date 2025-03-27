namespace oopiInCsharp;

class Star{
    public string name;
    public string type;
    public int age;
    public double brightness;
    
    public Star(string name, string type){
        this.name = name;
        this.type = type;
        this.age = 0;
        this.brightness = 1.0;
    }
    public Star(string name): this(name, "Unknown"){
        Console.WriteLine("Start type set to default: Unknown.");
    }
     
    public void Shine(){
        Console.WriteLine($"Star {name} is shining with brightness {brightness}.");
    }

    public void GrowOlder(){
        this.age += 1000000000;
        this.brightness *= 0.9;  
    }

    public void Supernova(){
        this.brightness = 0; 
        Console.WriteLine($"Star {name} has exploded in a supernova."); 
    }
    

}