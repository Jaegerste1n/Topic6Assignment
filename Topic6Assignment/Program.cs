namespace Topic6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int rand;
            rand = generator.Next(10);

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

        }
    }
}
