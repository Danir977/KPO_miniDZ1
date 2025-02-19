namespace EAnimalsLib;

public abstract class Omnivore : Animal
{
    public uint Friendliness { get; set; }
    
    protected Omnivore() { Friendliness = 0; }

    protected Omnivore(string name, int food, uint friendliness) : base(name, food)
    {
        Friendliness = friendliness;
    }
}