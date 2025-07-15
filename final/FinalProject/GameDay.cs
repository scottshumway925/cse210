class GameDay
{
    private int _timeLeftInDay;
    private int _dayCount;
    private int _requiredMoney;

    public GameDay()
    {
        _timeLeftInDay = 10;
        _dayCount = 1;
        _requiredMoney = 10;
    }

    public int GetTimeLeftInDay()
    {
        return _timeLeftInDay;
    }

    public float GetRequiredMoney()
    {
        return _requiredMoney;
    }

    public bool StartNextDay(Inventory inventory)
    {
        bool gameOver = false;
        if (_requiredMoney <= inventory.GetCurrentMoney())
        {
            gameOver = true;
        }
        _timeLeftInDay = 10;
        inventory.SubtractFromCurrentMoney(_requiredMoney);
        float requiredMoneyCalculation = _requiredMoney * 1.3f;
        _requiredMoney = (int)Math.Round(requiredMoneyCalculation);
        Console.Clear();
        if (gameOver)
        {
            Console.WriteLine($"You have successfully completed day {_dayCount}, leaving you with {inventory.GetCurrentMoney()} gold leftover.");
        }
        else
        {
            Console.WriteLine($"You lost on day {_dayCount}.");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        _dayCount++;
        return gameOver;
    }

    public void DisplayDayStart()
    {
        Console.Clear();
        Console.WriteLine($"You wake up to a beautiful day. This is day {_dayCount} of you running your alchemy shop.");
        Console.WriteLine($"The amount of money that you need to have by the end of this day is: {_requiredMoney} Gold");
        Console.WriteLine($"You have {_timeLeftInDay} actions available today. Use them well!");
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public void DecrementTimeInDay(int timeToSubtract)
    {
        _timeLeftInDay -= timeToSubtract;
    }
}