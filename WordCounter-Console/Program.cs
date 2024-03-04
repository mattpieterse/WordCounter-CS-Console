using System.ComponentModel.Design;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("| WordCounter (console/pre-0.1.0) |");
        Console.WriteLine("|---------------------------------|\n");

        Console.WriteLine("Enter your text to be parsed...");
        Console.Write(">> ");
        string text = Console.ReadLine();
        Menu(text);
    }

    static void Menu(string text) {
        Console.Write('\n');
        Console.WriteLine("1 : Get properties of text");
        Console.WriteLine("0 : Exit application");
        Console.Write(">> ");
        string opt = Console.ReadLine();
        Console.WriteLine();
        switch (opt) {
            case "1":
                Output(text);
                break;
        }
    }

    static void Output(string text) {
        Console.WriteLine($"Length: {GetSize(text)}");
        Console.WriteLine($"Words: {GetWords(text)}");
    }

    // 

    static int GetSize(string text) {
        return text.Length;
    }

    static int GetWords(string text) {
        int count = 0;
        for (int i = 0; i < text.Length; i++) {
            if (!char.IsWhiteSpace(text[i])) count++;
        }
        return count;
    }
}