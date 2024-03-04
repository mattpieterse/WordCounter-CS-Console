using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("| WordCounter (console/pre-0.1.0) |");
        Console.WriteLine("|---------------------------------|\n");

        Console.WriteLine("Enter your text to be parsed.");
        Console.Write(">> ");
        string text = Console.ReadLine();
        Menu();
    }

    static void Menu()
    {
        Console.Write('\n');
        Console.WriteLine("1 : Get properties of text");
        Console.WriteLine("0 : Exit application");
        Console.Write(">> ");
        string opt = Console.ReadLine();
        Console.WriteLine('\n');
        switch (opt)
        {
            // Switch logic here
        }
    }

    // 

    static int GetSize(string text)
    {
        return text.Length;
    }

    static int GetWords(string text) 
    {
        return 0;
    }
}