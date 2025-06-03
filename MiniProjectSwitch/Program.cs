namespace MiniProjectSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string? firstName = Console.ReadLine();
            Console.Write("What is your age: ");
            bool isValidAge = int.TryParse(Console.ReadLine(), out int age);
            switch (firstName.ToLower())
            {
                case "bob" or "sue":
                    Console.WriteLine($"Hello Professor {firstName}");
                    break;
                default:
                    Console.WriteLine($"Hello {firstName}");
                    break;
            }
            if (isValidAge) {
                switch (age)
                {
                    case < 21:
                        int X = 21 - age;
                        Console.WriteLine($"You should wait {X} years to start this class");
                        break;
                    default:
                        Console.WriteLine("Welcome to class.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You did not provide a valid age.");
            }
        }
    }
}
