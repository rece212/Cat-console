namespace Dealing_with_Consoles_and_ALL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=============================");
                Console.WriteLine("        SUPER MENU           ");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Analyze Text (Count & Uppercase)");
                Console.WriteLine("2. Reverse Text");
                Console.WriteLine("3. Exit Program");
                Console.WriteLine("=============================");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your choice (1, 2, or 3) ");
                Console.ResetColor();

                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter the text you want to analyze ");
                    Console.ResetColor();

                    string inputData = Console.ReadLine();

                    // Process the data
                    string upperData = inputData.ToUpper();
                    int dataLength = inputData.Length;

                    // Output the results
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Processing Complete!");
                    Console.WriteLine("Your text in uppercase " + upperData);
                    Console.WriteLine("Total characters found " + dataLength);
                    Console.WriteLine();
                }
                else if (userChoice == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter a word or phrase to reverse ");
                    Console.ResetColor();

                    string textToReverse = Console.ReadLine();

                    // Process the data
                    char[] charArray = textToReverse.ToCharArray();
                    Array.Reverse(charArray);
                    string reversedText = new string(charArray);

                    // Output the results
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Reversal Complete!");
                    Console.WriteLine("Your reversed text " + reversedText);
                    Console.WriteLine();
                }
                else if (userChoice == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Shutting down... Goodbye!");
                    Console.ResetColor();
                    isRunning = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid selection. Please try again.");
                    Console.WriteLine();
                    Console.ResetColor();

                    // The @ symbol allows multi-line strings and ignores escape characters
                    string catArt = @"
   /\_/\
  ( o.o )
   > ^ <

All done";

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Here is your ASCII cat:");
                    Console.WriteLine(catArt);
                    Console.ResetColor();



                }


            }
        }
    }
}
