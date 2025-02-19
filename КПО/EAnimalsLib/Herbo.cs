namespace EAnimalsLib;

public abstract class Herbo : Animal
{
    public uint Friendliness { get; set; }

    protected Herbo() { Friendliness = 0; }

    protected Herbo(string name, int food, uint friendliness) : base(name, food)
    {
        Friendliness = friendliness;
    }
}