using System;

class Program
{
    private static void MenuSelection()
    {
        int MenuSelection = 0;
        while (MenuSelection != 5)
        {
            // Menu Text
            Console.WriteLine("\nJournal Menu\n1. Display Journal\n2. Write Entry\n3. Load journal from file\n4. Save journal to file\n5. Quit");
            Console.Write("\nPlease enter your menu choice: ");
            MenuSelection = int.Parse(Console.ReadLine());

            switch (MenuSelection)
            {
                case 1:
                    Console.WriteLine("Option 1");
                    break;
                case 2:
                    Console.WriteLine("Option 2");
                    break;
                case 3:
                    Console.WriteLine("Option 3");
                    break;
                case 4:
                    Console.WriteLine("Option 4");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Incorrect entry");
                    break;
            }
        }
    }


    static void Main(string[] args)
    {
        MenuSelection();
    }
}