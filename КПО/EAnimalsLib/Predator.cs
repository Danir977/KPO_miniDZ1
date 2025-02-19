namespace EAnimalsLib;

public abstract class Predator : Animal
{
    public Predator() : base() {}
    
    public Predator(string name, int food) : base(name, food) {}
}