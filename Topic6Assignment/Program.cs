namespace Topic6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int rand;
            rand = generator.Next(10);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(rand);

            Console.WriteLine("");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.WriteLine("");

            int num1 = generator.Next(10);
            int num2 = generator.Next(10);
            Console.WriteLine(num1 + " " + num2);
            if (num1 == num2)
            {
                Console.WriteLine("They're the same.");

            }
            if (num1 != num2)
            {
                Console.WriteLine("They're different.");
            }
            int choice1, choice2;
            Console.WriteLine("Enter a min value and a max value.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out choice1);
            int.TryParse(Console.ReadLine(), out choice2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (choice1 >= choice2)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine(generator.Next(choice1, choice2) + " ");
            }
            int guessGame, guess;
            
            guessGame = generator.Next(10);
            Console.WriteLine("Guess a number between 1 and 10.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out guess);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (guess == guessGame)
            {
                Console.WriteLine("Wow. Great job.");
            }
            else
            {
                Console.WriteLine("Wrong. It was " + guessGame + ".");
            }
            int roll1, roll2;
            roll1 = generator.Next(1, 7);
            roll2 = generator.Next(1, 7);
            Console.WriteLine("Rolling dice.");
            Console.WriteLine(roll1 + " " + roll2);
            if (roll1 == 1 && roll2 == 1)
            {
                Console.WriteLine("Snake eyes. You have two minutes to live.");
            }
            if (roll1 == 12 && roll2 == 12)
            {
                Console.WriteLine("12. How lucky.");
            }
            int eightball;
            Console.WriteLine("Ask the Magic 8 Ball something.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            eightball = generator.Next(1, 9);
            if (eightball == 1)
            {
                Console.WriteLine("What is wrong with you?");
            }
            else if (eightball == 2)
            {
                Console.WriteLine("Shut up.");
            }
            else if (eightball == 3)
            {
                Console.WriteLine("Absolutely not.");
            }
            else if (eightball == 4)
            {
                Console.WriteLine("Never.");
            }
            else if (eightball == 5)
            {
                Console.WriteLine("Stake your life on it.");
            }
            else if (eightball == 6)
            {
                Console.WriteLine("Take your chances.");
            }
            else if (eightball == 7)
            {
                Console.WriteLine("AAHHHH!!! AARGHHH!!! AHAARGHH!!!!");
            }
            else if (eightball == 8)
            {
                Console.WriteLine("No");
            }
        }
    }
}
