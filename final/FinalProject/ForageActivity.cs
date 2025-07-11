class ForageActivity : Activity
{
    private List<Item> _foragableItems = new List<Item>();

    public ForageActivity(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {
        PopulateForagableList();
    }

    private void PopulateForagableList()
    {
        Item livingWood = new ConsumableItem("Living Wood", "Living Wood is a magical wood used to make weapons and armor that contain magical properties.", 2, 0);
        Item rawGold = new ConsumableItem("Raw Gold", "Raw gold is a very valuable metal, creating the most expensive of items.", 4, 0);
        Item rawIron = new ConsumableItem("Raw Iron", "Being a very versatile material, iron is used to create hardy weapons and armor of valor.", 2, 0);
        Item fiddleFern = new ConsumableItem("Fiddlefern", "This is a beautful green fern that grows at the base of mountainous terrain. It contains healing properties.", 2, 0);
        Item leprechaunsBud = new ConsumableItem("Leprachauns Bud", "This is a green budding plant that has golden accents. It is said to contain immense amounts of luck.", 2, 0);
        Item goldenBloom = new ConsumableItem("Golden Bloom", "This beautiful flower is gold and purple, showing only the most regal of colors. It is said to boost one's charisma.", 2, 0);
        Item toadStool = new ConsumableItem("Toadstool", "This simple mushroom is the basis of all magical potions.", 1, 0);
        Item flareLichen = new ConsumableItem("Fire Lichen", "This common plant can be used to create bars out of metal materials.", 1, 0);

        _foragableItems.Add(fiddleFern);
        _foragableItems.Add(leprechaunsBud);
        _foragableItems.Add(goldenBloom);
        _foragableItems.Add(rawGold);
        _foragableItems.Add(livingWood);
        _foragableItems.Add(livingWood);
        for (int i = 0; i < 3; i++)
        {
            _foragableItems.Add(toadStool);
            _foragableItems.Add(flareLichen);
            _foragableItems.Add(rawIron);
        }
    }

    public override void RunActivity(Inventory inventory, GameDay gameDay)
    {
        base.DisplayInformation();
        Console.WriteLine("Would you like to proceed with foraging?");
        Console.WriteLine("Press ENTER to continue or type 0 to exit");
        string performActivity = (Console.ReadLine());
        switch (performActivity)
        {
            case "":
                Console.Write("You start to forage in the wilds for crafting reagents");
                for (int i = 0; i < 3; i++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, _foragableItems.Count);
                    Console.WriteLine();
                    base.DisplayLoadingCharacters();
                    Console.WriteLine($"You found a {_foragableItems[randomNumber].GetName()}!");
                    inventory.AddItem(_foragableItems[randomNumber]);
                }
                gameDay.DecrementTimeInDay(base.GetActionCost());
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                break;
            default:
                break;
        }
    }
}