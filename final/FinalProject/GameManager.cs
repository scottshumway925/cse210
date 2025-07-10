using System.Diagnostics;

class GameManager
{
    GameDay _gameDay = new GameDay();
    Inventory _inventory = new Inventory();

    public void RunGame()
    {
        _gameDay.DisplayDayStart();
        while (_gameDay.GetTimeLeftInDay() >= 0)
            RunActivities();
    }

    public void RunActivities()
    {
        Console.WriteLine($"You have {_gameDay.GetTimeLeftInDay()} actions left in this day");
        Console.WriteLine("Here are the available avtions for you to take:\n  1. Forage for materials\n  2. Sell and item\n  3. Craft an item");
        Console.WriteLine("Please enter a nuber representing the activity you would like to do.");
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
            default:
                _activity = null;
                break;
        }

        if (_activity != null)
        {
            _activity.RunActivity(_inventory, _gameDay);
        }
        else
        {
            Console.WriteLine("Please enter a valid option (1, 2, 3)");
        }
    }
}