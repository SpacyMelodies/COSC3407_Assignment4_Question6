
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Page number and Offset Calculator");
            decimal pageSize = GetDecimal("What is the size of the page? Please enter total bit value! example: 1kb page -> enter 1000 :  ");
            decimal addressReference = GetDecimal("Please enter the address reference:  ");
            Console.WriteLine(GetPageNumber(pageSize, addressReference));
            Console.WriteLine(GetOffset(pageSize, addressReference));
            Console.WriteLine("calculate another value? any key to continue, n to exit");
            string decision = Console.ReadLine().ToUpper();
            if (decision == "N")
            {
                return;
            }
            else
            {
                Console.Clear();
            }
        }


    }

    private static string GetOffset(decimal pageSize, decimal addressReference)
    {
        decimal result = addressReference % pageSize;
        return $"Offset is {result}";
    }

    private static string GetPageNumber(decimal pageSize, decimal addressReference)
    {
        decimal result = addressReference / pageSize;
        return $"Page number is {result}";
    }

    public static decimal GetDecimal(string userMessage)
    {
        Console.Write(userMessage);
        bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal returnValue);
        while (!isDecimal)
        {
            Console.WriteLine("please enter a valid decimal value");
            isDecimal = decimal.TryParse(Console.ReadLine(), out  returnValue); ;
        }
        return returnValue;
    }
}