using System;
using System.Runtime.InteropServices;

class Program
{
    private static void MenuSelection()
    {
        Journal journal = new Journal();
        int MenuSelection = 0;
        while (MenuSelection != 6)
        {
            // Menu Text
            Console.WriteLine("\nJournal Menu\n1. Display Journal\n2. Write Entry\n3. Set filename\n4. Load journal from file\n5. Save journal to file\n6. Quit");
            Console.Write("\nPlease enter your menu choice: ");
            MenuSelection = int.Parse(Console.ReadLine());

            // Switch case designed to determine what the user wants to do.
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
                    // This case handles getting the filename to load to and save from. 
                    journal.SetFileName();
                    break;

                case 4:
                    // This case handles loading the journal from a file.
                    try
                    {
                        journal.LoadFile(journal.GetFileName());
                    }
                    catch (Exception) // Sets the filename if it's not already set.
                    {
                        journal.SetFileName();
                        journal.LoadFile(journal.GetFileName());
                    }
                    break;

                case 5:
                    // This case handles saving the journal to a file.
                    try
                    {
                        journal.SaveFile(journal.GetFileName());
                    }
                    catch (Exception) // Sets the filename if it's not already set.
                    {
                        journal.SetFileName();
                        journal.SaveFile(journal.GetFileName());
                    }

                    break;

                case 6:
                    // This case is the exit case.
                    break;
                default:
                    // Error handling
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