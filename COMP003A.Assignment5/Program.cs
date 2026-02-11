namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayIntroduction();

            bool runAgain = true;

            while (runAgain)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter a whole number:");
                int number = int.Parse(Console.ReadLine());

                DisplayUserInput(name, number);

                int result = CalculateResult(number);

                Console.WriteLine("Calculated result: " + result);

                Console.Write("Would you like to run the program again? (y/n): ");
                string answer = Console.ReadLine();

                runAgain = (answer == "y" || answer == "Y");
                Console.WriteLine();

                Console.WriteLine("Program ended.");

            }

            static void DisplayIntroduction()
            {
                Console.WriteLine("Welcome to the Program Organizer!");
                Console.WriteLine();
            }
        }
    }
}
