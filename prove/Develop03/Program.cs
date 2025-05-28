using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his only Son, that whoever believes in him shall not perish but have eternal life");
        bool isFinished = false;

        while (!isFinished)
        {
            scripture.DisplayScripture();
            Console.WriteLine("Press 'Enter' to remove words or 'Q' to exit the program");
            string response = Console.ReadLine();
            if (response == "")
            {
                isFinished = scripture.HideWords();
            }
            else if (response.ToUpper() == "Q")
            {
                isFinished = true;
            }
        }
        
    }
}