using System;

namespace NestedIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of NESTED IF Else Construct");

            comparison();
        }

        static void comparison()
        {
            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("The first number is : " + first);
            Console.WriteLine("The second number is : " + second);
            Console.WriteLine("The third number is : " + third);

            if (first > second)
            {
                if (first > third)
                {
                    Console
                        .WriteLine("The highest number is the first number" +
                        first);
                }
                else
                {
                    Console
                        .WriteLine("The highest number is the third number : " +
                        third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console
                        .WriteLine("The second number is the highest number: " +
                        second);
                }
                else
                {
                    Console
                        .WriteLine("The third number is the highest number: " +
                        third);
                }
            }

            Console.WriteLine("WANT TO ENTER AGAIN [Y/N]? ");
            String s = Console.ReadLine();

            if ((s == "y") || (s == "Y"))
            {
                comparison();
            }
            else
            {
                Console.WriteLine("Thank you for using this program, bye...");
            }
        }
    }
}
