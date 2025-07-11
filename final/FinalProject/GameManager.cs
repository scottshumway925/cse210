using System.Diagnostics;

class GameManager
{
    GameDay _gameDay = new GameDay();
    Inventory _inventory = new Inventory();

    public void RunGame()
    {
        do
        {
            _gameDay.DisplayDayStart();
            while (_gameDay.GetTimeLeftInDay() > 0)
                RunActivities();
            _gameDay.StartNextDay();
        } while (_gameDay.GetRequiredMoney() <= _inventory.GetCurrentMoney());      
    }

    public void RunActivities()
    {
        Console.Clear();
        Console.WriteLine($"You have {_gameDay.GetTimeLeftInDay()} actions left in this day");
        Console.WriteLine($"You currently have {_inventory.GetCurrentMoney()}/{_gameDay.GetRequiredMoney()} Gold for the day");
        Console.WriteLine("Here are the available avtions for you to take:\n  1. Forage for materials\n  2. Sell and item\n  3. Craft an item\n  4. View Inventory");
        Console.Write("Please enter a number representing the activity you would like to do: ");
        int chosenActivity = int.Parse(Console.ReadLine());
        Activity _activity;

        switch (chosenActivity)
        {
            case 1:
                _activity = new ForageActivity("Forage for Reagents", "Description", 2);
                break;
            case 2:
                _activity = new SellActitivy("Sell an Item", "Description", 1);
                break;
            case 3:
                _activity = new CraftActivity("Craft an Item", "Description", 2);
                break;
            case 4:
                _activity = null;
                _inventory.DisplayContents();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Please enter a valid option ex. 1, 2, 3...");
                _activity = null;
                break;
        }

        if (_activity != null)
        {
            _activity.RunActivity(_inventory, _gameDay);
        }
    }
}