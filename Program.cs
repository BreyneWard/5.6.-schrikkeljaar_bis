namespace _5._6._schrikkeljaar_bis;
class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine($"Geef een jaartal op:");
        string input = Console.ReadLine();
        int jaartal; 
        while (string.IsNullOrEmpty(input) || !int.TryParse(input, out jaartal) || jaartal <= 0)
        {
            Console.WriteLine($"Input is empty, null, negative or not a number!, Give up a whole number: ");
            input = Console.ReadLine();
        }
        Console.WriteLine("{0} is {1}een schrikkeljaar", jaartal, CalculateLeapYear(jaartal) ? "" : "g");
    }

    // Methods
    static bool CalculateLeapYear(int jaartal)
    {
        if (jaartal % 4 == 0 && !(jaartal % 100 == 0))
        {
            return true;
        }
        else if (jaartal % 4 == 0 && jaartal % 100 == 0 && jaartal % 400 == 0 )
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
}
