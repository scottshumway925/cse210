public class Journal
{
    List<string> _entries = new List<string>();
    string _filename;

    public void DisplayJournal()
    {
        foreach (string entry in this._entries)
        {
            string[] parts = entry.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Console.WriteLine($"{date}\n{prompt}\n\n{text}\n");
        }
    }

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public void SaveFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename)) {
            foreach (string entry in _entries)
            {
                sw.WriteLine(entry);
            }
        }
    }

    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            string textEntry = entry.CreateEntryWithData(date, question, text);
            this.AddEntry(textEntry);
        }
    }

    public void SetFileName()
    {
        Console.Write("What is the name of the file you would like to use? ");
        _filename = Console.ReadLine();
    }

    public string GetFileName()
    {
        return _filename;
    }
}