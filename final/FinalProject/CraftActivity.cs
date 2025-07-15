using System.Threading.Channels;

class CraftActivity : Activity
{
    public CraftActivity(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {

    }


    public override void RunActivity(Inventory inventory, GameDay gameDay)
    {
        base.DisplayInformation();
        Console.WriteLine("Would you like to proceed with crafting?");
        Console.WriteLine("Press ENTER to continue or type 0 to exit");
        string performActivity = (Console.ReadLine());
        switch (performActivity)
        {
            case "":
                Console.WriteLine("Here is your inventory:");
                inventory.DisplayContents();
                Console.WriteLine("\nHere are the available crafting recipes");
                inventory.DisplayRecipes();
                Console.WriteLine("\nPlease enter the number you would like to craft!");
                try
                {
                    int craftNumber = int.Parse(Console.ReadLine()) - 1;
                    ItemRecipe chosenItem = inventory.GetRecipeList()[craftNumber];
                    if (chosenItem.CheckForRequirements(inventory))
                    {
                        inventory.AddItem(new Item(chosenItem.GetName(), chosenItem.GetDefinition(), chosenItem.GetSellAmount(), 1));
                        gameDay.DecrementTimeInDay(base.GetActionCost());
                        Console.WriteLine($"You have successfully crafted a {chosenItem.GetName()}.\nPress enter to continue: ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You do not meet the requirements to craft that item. Please try again with an item you can craft");
                        Console.Write("Press enter to continue");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("That was not a valid number. Please try again with a valid input.\nPress enter to continue.");
                    Console.ReadLine();
                }
                break;
            default:
                break;
        }
    }
}