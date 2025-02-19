namespace EBasicClassesLib;

public class InventoryNumberGenerator
{
    public static string Generate()
    {
        return Guid.NewGuid().ToString();
    }
}