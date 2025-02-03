class Clocktower
{
    static void Main()
    {
        //ask for user input
        System.Console.Write("Enter a number: ");
        int number = Convert.ToInt32(System.Console.ReadLine());

        //check if the number is even or odd
        if (number % 2 == 0)
        {
            System.Console.WriteLine("Tick"); // Even number
        }
        else
        {
            System.Console.WriteLine("Tock"); // Odd number
        }
    }
}

