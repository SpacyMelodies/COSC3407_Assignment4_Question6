
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Page number and Offset Calculator");
            Console.WriteLine("--------------------");
            decimal pageSize = GetDecimal("What is the size of the page? Please enter total bit value! example: 1kb page -> enter 1000 :  ");
            decimal addressReference = GetDecimal("Please enter the address reference:  ");
            Console.WriteLine(GetPageNumber(pageSize, addressReference));
            Console.WriteLine(GetOffset(pageSize, addressReference));

            // if user enters n, we exit. else, clear console and start another calculation
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

    // Calculates Offset
    private static string GetOffset(decimal pageSize, decimal addressReference)
    {
        decimal result = addressReference % pageSize;
        return $"Offset is {result}";
    }

    // Calculates Page Number
    private static string GetPageNumber(decimal pageSize, decimal addressReference)
    {
        decimal result = addressReference / pageSize;
        return $"Page number is {result}";
    }

    // takes a message to be delivered to the user and returns a inputted decimal value to the main function
    public static decimal GetDecimal(string userMessage)
    {
        Console.Write(userMessage);
        bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal returnValue);

        // until the user enters a valid decimal value, reprompts them
        while (!isDecimal)
        {
            Console.WriteLine("please enter a valid decimal value");
            isDecimal = decimal.TryParse(Console.ReadLine(), out  returnValue); ;
        }
        return returnValue;
    }
}