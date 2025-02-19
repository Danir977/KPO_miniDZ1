using EAnimalsLib;

namespace KPO_mini_DZ1;

public class Menu
{
    private readonly Zoo _zoo;
    
    public Menu(Zoo zoo)
    {
        _zoo = zoo;
    }
    
    public void ShowMainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Показать список жиотных, которых можно добавить в контактный зоопарк");
            Console.WriteLine("3. Показать потребности в еде у всех животных");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");
            
            string choice = Console.ReadLine();
            HandleUserChoice(choice);
        }
    }
    
    private void HandleUserChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                AddAnimalFromUser();
                break;
            case "2":
                ShowContactZooAnimals();
                break;
            case "3":
                ShowFoodRequirements();
                break;
            case "4":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Неверный ввод, попробуйте снова.");
                Console.Write("Enter -> вернуться к меню: ");
                Console.ReadLine();
                break;
        }
    }
    
    private void AddAnimalFromUser()
    {
        Console.Write("Введите имя животного: ");
        string name = Console.ReadLine();
        
        Console.Write("Введите количество потребляемой еды: ");
        int food = Convert.ToInt32(Console.ReadLine());

        Console.Write("Выберите вид животного (1 - Кролик, 2 - Обезьяна, 3 - Волк, 4 - Тигр): ");
        
        Animal newAnimal = null;
        string type = Console.ReadLine();
        
        switch (type)
        {
            case "1":
                Console.Write("Введите уровень дружелюбности (0-10): ");
                uint friendliness_1 = uint.TryParse(Console.ReadLine(), out uint fr_1) ? fr_1 : 0;
                newAnimal = new Rabbit(name, food, friendliness_1);
                break;
            case "2":
                Console.Write("Введите уровень дружелюбности (0-10): ");
                uint friendliness_2 = uint.TryParse(Console.ReadLine(), out uint fr_2) ? fr_2 : 0;
                newAnimal = new Monkey(name, food, friendliness_2);
                break;
            case "3":
                newAnimal = new Wolf(name, food);
                break;
            case "4":
                newAnimal = new Tiger(name, food);
                break;
            default:
                Console.WriteLine("Неверный вид.");
                return;
        }
        
        _zoo.AddAnimal(newAnimal);
        _zoo.AddAnimalToContactZoo(newAnimal);
        
        Console.Write("Enter -> вернуться к меню: ");
        Console.ReadLine();
    }
    
    private void ShowContactZooAnimals()
    {
        _zoo.AllFriendlyAnimals();
        Console.Write("Enter -> вернуться к меню: ");
        Console.ReadLine();
    }
    
    private void ShowFoodRequirements()
    {
        Console.WriteLine("Общее количество корма: " + _zoo.TotalFoodConsumption());
        Console.Write("Enter -> вернуться к меню: ");
        Console.ReadLine();
    }
}
