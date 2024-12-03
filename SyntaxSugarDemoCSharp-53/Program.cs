namespace SyntaxSugarDemoCSharp_53;

class Program
{
    static void Main(string[] args)
    {
        //Explicit typing
        int number = 10;
        string word;
        
        //Inferred typing
        var myVariable = "word";
        
        //inline if statement (ternary operator)

        var age = 17;

        Console.WriteLine(age >= 18 ? "You're an adult." : age < 6 ? "You're a child." : "You're a minor.");
        
        //string interpolation vs concatenation

        var middleInitial = 'S';

        Console.WriteLine($"Brandon {middleInitial} Bowman");
        Console.WriteLine("Brandon" + " " + middleInitial + " " + "Bowman");
    }
}
