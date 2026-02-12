namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Why methods exist is to make the program look organize and to make the steps look clear
           // Methods uses parameters and return values while Main controls the program
            
            DisplayIntroduction(); 

            bool runAgain = true;

            // The loop depends on the user input
            while (runAgain)
            {
              // This must be read in Main
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                // Passed values to a method using parameters
                DisplayUserInput(name, number);

                // Stores returned value in Main 
                int result = CalculateResult(number);

                Console.WriteLine("Calculated result: " + result);

                // Returned value in Main for decision making
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
            
            // This shows the program introduction message
            // It only prints its own message
            static void DisplayIntroduction()
            {
                Console.WriteLine("Welcome to the Program Organizer!");
                Console.WriteLine();
            }

            // This is to pass multiple values into a method using parameters
            // Only parameters, and not variables from Main
            static void DisplayUserInput(string userName, int userNumber)
            {
                Console.WriteLine();
                Console.WriteLine("You entered Name: " + userName + ", Number: " + userNumber);
                Console.WriteLine();
            }
            
            // This is to calculate using the numeric value and to retun the result
            static int CalculateResult(int value)
            {
                int calculated = value * 2;
                return calculated;
            }
        }
    }
}
