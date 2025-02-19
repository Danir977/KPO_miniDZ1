namespace EBasicClassesLib;

public abstract class Thing : IInventory
{
    public string Name { get; set; }
    public string Number { get; set; }

    protected Thing()
    {
        Name = "Unknown";
        Number = "-1";
    }

    protected Thing(string name)
    {
        Name = name;
        Number = InventoryNumberGenerator.Generate();
    }
}
