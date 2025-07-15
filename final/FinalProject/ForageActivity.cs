class ForageActivity : Activity
{
    private List<Item> _foragableItems = new List<Item>();

    public ForageActivity(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {
        PopulateForagableList();
    }

    private void PopulateForagableList()
    {
        Item livingWood = new Item("Living Wood", "Living Wood is a magical wood used to make weapons and armor that contain magical properties.", 2, 0);
        Item rawGold = new Item("Raw Gold", "Raw gold is a very valuable metal, creating the most expensive of items.", 4, 0);
        Item rawIron = new Item("Raw Iron", "Being a very versatile material, iron is used to create hardy weapons and armor of valor.", 2, 0);
        Item fiddleFern = new Item("Fiddle Fern", "This is a beautful green fern that grows at the base of mountainous terrain.", 2, 0);
        Item leprechaunsBud = new Item("Leprachauns Bud", "This green and gold plant is said to contain immense amounts of luck.", 2, 0);
        Item goldenBloom = new Item("Golden Bloom", "This beautiful flower is gold and purple,. It is said to boost one's charisma.", 2, 0);
        Item toadStool = new Item("Toadstool", "This simple mushroom is the basis of all magical potions.", 1, 0);
        Item flareLichen = new Item("Fire Lichen", "This common plant can be used to create bars out of metal materials.", 1, 0);

        _foragableItems.Add(fiddleFern);
        _foragableItems.Add(leprechaunsBud);

        for (int i = 0; i < 3; i++)
        {
            _foragableItems.Add(rawIron);
            _foragableItems.Add(toadStool);
            _foragableItems.Add(flareLichen);
        }
        for (int i = 0; i < 2; i++)
        {
            _foragableItems.Add(livingWood);
            _foragableItems.Add(goldenBloom);
            _foragableItems.Add(rawGold);
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