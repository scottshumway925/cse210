using System.Diagnostics;

class GameManager
{
    private GameDay _gameDay = new GameDay();
    private Inventory _inventory = new Inventory();
    private bool _gameOver = false;

    public GameManager()
    {

    }

    public void RunGame()
    {
        do
        {
            _gameDay.DisplayDayStart();
            while (_gameDay.GetTimeLeftInDay() > 0)
                RunActivities();
            _gameOver = _gameDay.StartNextDay(_inventory);
        } while (_gameOver == true);
        Console.WriteLine("\nYour shop has grown too big for your current operations, and you will likely need to shut down.\n\nThank you for playing!");
    }

    public void RunActivities()
    {
        Console.Clear();
        Console.WriteLine($"You have {_gameDay.GetTimeLeftInDay()} actions left in this day");
        Console.WriteLine($"You currently have {_inventory.GetCurrentMoney()}/{_gameDay.GetRequiredMoney()} Gold for the day");
        Console.WriteLine("Here are the available avtions for you to take:\n  1. Forage for materials\n  2. Sell and item\n  3. Craft an item\n  4. View Inventory");
        Console.Write("Please enter a number representing the activity you would like to do: ");
        try
        {
            int chosenActivity = int.Parse(Console.ReadLine());
            Activity _activity;

            switch (chosenActivity)
            {
                case 1:
                    _activity = new ForageActivity("Forage for Reagents", "This action allows you to search for 3 reagents.", 2);
                    break;
                case 2:
                    _activity = new SellActitivy("Sell an Item", "This action allows you to either sell your reagents or crafted items.", 1);
                    break;
                case 3:
                    _activity = new CraftActivity("Craft an Item", "This action allows you to craft new items out of your gathered materials.", 1);
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
        catch
        {
            Console.WriteLine("Please enter a valid input...\nPress enter to continue: ");
            Console.ReadLine();
        }

    }
}