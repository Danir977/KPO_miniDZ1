namespace EBasicClassesLib;

public abstract class Computer : Thing
{
    public string Processor{ get; set; }

    public Computer() : base()
    {
        Processor = "Unknown";
    }

    public Computer(string name, string processor) : base(name)
    {
        Processor = processor;
    }
    
    
}