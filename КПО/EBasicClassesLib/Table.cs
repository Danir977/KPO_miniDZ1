namespace EBasicClassesLib;

public abstract class Table : Thing
{
    public uint NumberOfLegs { get; set; }

    public Table() : base()
    {
        NumberOfLegs = 4;
    }

    public Table(string name, uint numberOfLegs) : base(name)
    {
        NumberOfLegs = numberOfLegs;
    }
}