using EBasicClassesLib;

namespace EAnimalsLib;

public abstract class Animal : Thing, IAlive, IInventory
{
    public int Food { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public bool IsHealthy { get; set; }

    protected Animal()
    {
        Food = 0;
        Number = "-1";
        Name = "Unknown";
        IsHealthy = false;
    }

    protected Animal(string name, int food)
    {
        Number = InventoryNumberGenerator.Generate();
        Name = name;
        Food = food;
        IsHealthy = false;
    }
}