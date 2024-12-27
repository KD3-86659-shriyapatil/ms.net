using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assign1Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter  numbers1-");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  numbers2-");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Opeation (+,-,*,/)-");
            char operation = Console.ReadKey().KeyChar;
           

            double result;

            switch (operation) {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"result-{num1}+{num2}={result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"result-{num1}-{num2}={result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"result-{num1}*{num2}={result}");
                    break;
                case '/':
                    result = num1 + num2;
                    Console.WriteLine($"result-{num1}/{num2}={result}");
                    break;
                   


            }
    


        }
    }
}
