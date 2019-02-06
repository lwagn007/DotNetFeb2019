using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();

            string hello = "Hello World";

            Console.WriteLine(hello);
            Console.ReadLine();

            string firstName = "Whatever name you want to use";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " + lastName);

            Console.WriteLine($"Good Morning, {firstName}{lastName}");
            Console.ReadLine();

            Console.WriteLine("Please enter your first name.");
            string firstNameTwo = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastNameTwo = Console.ReadLine();

            Console.WriteLine();

            int returnedResult = AddTwoNumbers(3, 3);
            Console.WriteLine(returnedResult);

            Console.WriteLine("Hello " + firstNameTwo + lastNameTwo);
        }

        static int AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}