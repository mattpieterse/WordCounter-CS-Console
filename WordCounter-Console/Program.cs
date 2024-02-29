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
    }

    static void Menu()
    {
        Console.Write('\n');
        Console.WriteLine("1 : Get properties of text");
        Console.WriteLine("0 : Exit application");
        switch ((string) Console.ReadLine)
        {

        }
        Console.Write('\n');
    }

    // 
}