// We want to develop a program that can do the following:

// · Prompt the user for input of two integers, which we will call numerator and denominator. For clarity, we are only looking at integers, because this assignment is about rational numbers. A rational number can always be expressed as a quotient of two integers.

// · Calculate the floating point division result (e.g. 10/4 = 2.5).

// · Calculate the quotient and the remainder (e.g. 10/4 = 2 with a remainder of 2 = 2 2/4).

// Your final program should work as in this sample run, and use the same labeled format:

// Please enter the numerator? 14

// Please enter the denominator? 4

// Integer division result = 3 with a remainder 2

// Floating point division result = 3.5

// The result as a mixed fraction is 3 2/4.

using System;
class Program
{

    // Main Method
    static public void Main()
    {

        // this is about first Question
        void problem1()
        {

            Console.WriteLine("Enter the Numerator::");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Denominator::");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a / b;
            int d = a % b;

            Console.WriteLine($"Integer Division Result is= {c} with Reminder is {d}");
            float e = (float)a / (float)b;
            Console.WriteLine($"Float point Division Result is= {e}");
            Console.WriteLine($"The result as a mixed fraction is={c} {d}/{b}");
        }

        problem1();

    }

}
