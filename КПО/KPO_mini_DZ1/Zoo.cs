using EAnimalsLib;
using EBasicClassesLib;

namespace KPO_mini_DZ1;

public class Zoo
{
    private List<Animal> _animals;
    private List<Animal> _contactZooAnimals;
    private readonly VetClinic _vetClinic;

    public Zoo(VetClinic vetClinic)
    {
        _animals = new List<Animal>();
        _contactZooAnimals = new List<Animal>();
        
        _vetClinic = vetClinic;
    }
    
    public void AddAnimal(Animal animal)
    {
        try
        {
            if (_vetClinic.CheckHealth(animal))
            {
                _animals.Add(animal);
                Console.WriteLine($"Животное {animal.Name} с ID {animal.Number} успешно принято в зоопарк.");
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void AddAnimalToContactZoo(Animal animal)
    {
        if (_animals.Contains(animal))
        {
            if (_vetClinic.IsFriendly(animal))
            {
                _contactZooAnimals.Add(animal);
                Console.WriteLine(
                    $"Животное {animal.Name} с ID {animal.Number} может быть добавлено в контактный зоопарк.");
            }
            else
            {
                Console.WriteLine(
                    $"Животное {animal.Name} с ID {animal.Number} не подходит для контактного зоопарка.");
            }
        }
        else
        {
            Console.WriteLine($"{animal.Name} с ID {animal.Number} не может быть добавлено в контактный зоопарк," +
                              $" так как не прошло проверку здоровья и не было принято в основной зоопарк.");
        }
    }

    public void AllFriendlyAnimals()
    {
        Console.WriteLine("{0,-20} {1,-20} {2,-50} {3,-25} {4,-10}", 
            "Имя", "Дружелюбность", "Инвентаризационный номер", "Потребление еды", "Здоровье");

        foreach (var animal in _contactZooAnimals)
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-50} {3,-25} {4,-10}",
                animal.Name,
                ((dynamic)animal).Friendliness,
                animal.Number,
                animal.Food,
                animal.IsHealthy ? "Здорово" : "Не здорово"
            );
        }
    }

    public int TotalFoodConsumption()
    {
        return _animals.Sum(animal => animal.Food);
    }

}