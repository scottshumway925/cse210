public class Journal
{
    List<string> _entries = new List<string>();

    public void DisplayJournal()
    {
        foreach (string entry in this._entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }
}