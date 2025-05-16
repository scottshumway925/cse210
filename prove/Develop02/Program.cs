using System;

class Program
{
    private static void MenuSelection()
    {
        Journal journal = new Journal();
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
                    // This case displays each journal entry in the journal.
                    journal.DisplayJournal();
                    break;

                case 2:
                    // This case handles creating a new entry and adding it to the Journal.
                    Entry journalEntry = new Entry();
                    string entryText = journalEntry.CreateEntryText();
                    journal.AddEntry(entryText);
                    break;

                case 3:
                    // This case handles loading the journal from a file.
                    break;
                case 4:
                    // This case handles saving the journal to a file.
                    break;
                case 5:
                    // This case is the exit case.
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