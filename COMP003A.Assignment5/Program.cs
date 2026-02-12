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

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                DisplayUserInput(name, number);

                int result = CalculateResult(number);

                Console.WriteLine("Calculated result: " + result);

                if (result > 10)
                {
                    Console.WriteLine("The result is greater than 10.");
                }
                else
                {
                    Console.WriteLine("The result is 10 or less.");
                }

                Console.Write("Would you like to run the program again? (y/n): ");
                string answer = Console.ReadLine();

                runAgain = (answer.ToLower() == "y");
                Console.WriteLine();

            }

            Console.WriteLine("Program ended.");
            
            static void DisplayIntroduction()
            {
                Console.WriteLine("Welcome to the Program Organizer!");
                Console.WriteLine();
            }

            static void DisplayUserInput(string userName, int userNumber)
            {
                Console.WriteLine();
                Console.WriteLine("You entered Name: " + userName + ", Number: " + userNumber);
                Console.WriteLine();
            }

            static int CalculateResult(int value)
            {
                int calculated = value * 2;
                return calculated;
            }
        }
    }
}
