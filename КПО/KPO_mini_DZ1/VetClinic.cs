using EAnimalsLib;

namespace KPO_mini_DZ1;

public class VetClinic
{
    private Random _random = new Random();
    
    public bool CheckHealth(Animal animal)
    {
        int isHealthy = _random.Next(0, 2);
        animal.IsHealthy = isHealthy == 1;

        if (isHealthy == 0)
        {
            throw new InvalidOperationException($"Животное {animal.Name} не прошло проверку здоровья" +
                                                $" и не может быть принято в зоопарк.");
        }
        
        return animal.IsHealthy;
    }

    public bool IsFriendly(Animal animal) => animal switch
    {
        Herbo herbo => herbo.Friendliness >= 5,
        Omnivore omnivore => omnivore.Friendliness >= 5,
        _ => false
    };

    
}