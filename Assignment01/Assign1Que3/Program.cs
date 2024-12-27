namespace Assign1Que3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter  numbers1-");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  numbers2-");
            int num2 = int.Parse(Console.ReadLine());

            bool exit = false;
            while (!exit) {
                Console.Write("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Multiplicatiion");
                Console.WriteLine("4.Division");
                Console.WriteLine("Enter your choice-");
                String choice = Console.ReadLine();

                double result;

                switch (choice) {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"result-{num1}+{num2}={result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"result-{num1}-{num2}={result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"result-{num1}*{num2}={result}");
                        break;
                    case "4":
                        result = num1 + num2;
                        Console.WriteLine($"result-{num1}/{num2}={result}");
                        break;
                }

            }
        
        }
    }
}
