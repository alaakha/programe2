namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char selection = ' ';

            do
            {
                Console.WriteLine("\n---------------------");
                Console.WriteLine("1. Do this");
                Console.WriteLine("2. Do that");
                Console.WriteLine("3. Do something else");
                Console.WriteLine("Q. Quit");
                Console.Write("\nEnter your selection: ");
                selection = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                if (selection == '1')
                    Console.WriteLine("You chose 1 - doing this");
                else if (selection == '2')
                    Console.WriteLine("You chose 2 - doing that");
                else if (selection == '3')
                    Console.WriteLine("You chose 3 - doing something else");
                else if (selection == 'Q')
                    Console.WriteLine("Goodbye...");
                else
                    Console.WriteLine("Unknown option -- try again...");

            } while (selection != 'Q');
        }
    }
}
