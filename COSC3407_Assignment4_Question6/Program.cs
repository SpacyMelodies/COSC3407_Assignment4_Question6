internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Page number and Offset Calculator");
            Console.WriteLine("--------------------");
            int pageSize = GetInteger("What is the size of the page? Please enter total bit value! example: 1kb page -> enter 1000 :  ");
            int addressReference = GetInteger("Please enter the address reference:  ");
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
    private static string GetOffset(int pageSize, int addressReference)
    {
        int result = addressReference % pageSize;
        return $"Offset is {result}";
    }

    // Calculates Page Number
    private static string GetPageNumber(int pageSize, int addressReference)
    {
        int result = addressReference / pageSize;
        return $"Page number is {result}";
    }

    // takes a message to be delivered to the user and returns a inputted int value to the main function
    public static int GetInteger(string userMessage)
    {
        Console.Write(userMessage);
        bool isDecimal = int.TryParse(Console.ReadLine(), out int returnValue);

        // until the user enters a valid int value, reprompts them
        while (!isDecimal)
        {
            Console.WriteLine("please enter a valid int value");
            isDecimal = int.TryParse(Console.ReadLine(), out returnValue); ;
        }
        return returnValue;
    }
}