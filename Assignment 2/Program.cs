using System;

class Program
{
    public static void Main(string[] args)
    {

        int a = 10, b = 5, c = 15;
        // double x = 5, y = 10, z = 15;

        // this is first part numbers in c#
        // add(a, b);
        // sub(a, b);
        // mul(a, b);
        // div(a, b);
        // complex1(a,b,c);
        // complex2(a,b,c);
        // findMinMax();
        // doubleArith(x,y,z);
        // doubleMinMax();
        // roundingError();
        // decimalMinMax();
        // decimalDouble();
        // areaOfCircle(a);


        // second part branching and loops part
        branching(a, b);
        ifElse1(a, b);
        compare1(a, b, c);
        compare2(a, b, c);
        whileLoop();
        doWhileLoop();
        forLoop();
        nestedLoop();
        isDivisibleBy3();

    }

    // first part numbers in c# 
    // public static void add(int m, int n)
    // {
    //     int p = m + n;
    //     Console.WriteLine("The Addition is :" + p);
    // }
    // public static void sub(int m, int n)
    // {
    //     int p = m - n;
    //     Console.WriteLine("The Substraction is :" + p);
    // }
    // public static void mul(int m, int n)
    // {
    //     int p = m * n;
    //     Console.WriteLine("The Multipication is :" + p);
    // }
    // public static void div(int m, int n)
    // {
    //     int p = m / n;
    //     Console.WriteLine("The Division is :" + p);
    // }
    // public static void complex1(int m, int n, int h)
    // {
    //     int p = m + n * h;
    //     Console.WriteLine("The result is :" + p);
    // }
    // public static void complex2(int m, int n, int h)
    // {
    //     int p = (m + n) / h;
    //     int q = (m + n) % h;

    //     Console.WriteLine("The quotient :" + p);
    //     Console.WriteLine("The reminder is :" + q);
    // }
    // public static void findMinMax()
    // {
    //     int p = int.MaxValue;
    //     int q = int.MinValue;

    //     Console.WriteLine("The integer minValue is :" + q);
    //     Console.WriteLine("The integer maxValue is :" + p);
    // }

    // public static void doubleArith(double m, double n, double h)
    // {
    //     double p = (m + n) / h;

    //     Console.WriteLine("The result of this expression (m+n)/h :" + p);

    // }
    // public static void doubleMinMax()
    // {
    //     double p = double.MaxValue;
    //     double q = double.MinValue;

    //     Console.WriteLine("The double minValue is :" + q);
    //     Console.WriteLine("The double maxValue is :" + p);
    // }

    // public static void roundingError()
    // {
    //     double t = 1.0 / 3.0;
    //     Console.WriteLine("Rounding error in double is:" + t);
    // }

    // public static void decimalMinMax()
    // {
    //     decimal p = decimal.MaxValue;
    //     decimal q = decimal.MinValue;

    //     Console.WriteLine("The decimal minValue is :" + q);
    //     Console.WriteLine("The decimal maxValue is :" + p);
    // }
    // public static void decimalDouble()
    // {
    //     double p = 1.0;
    //     double q = 3.0;
    //     Console.WriteLine("The value of (p/q) :" + (p / q));
    //     decimal c = 1.0M;
    //     decimal d = 3.0M;
    //     Console.WriteLine("The decimal value of (p/q) :" + (c / d));
    // }

    // public static void areaOfCircle(int a)
    // {
    //     double area = Math.PI * a * a;
    //     Console.WriteLine("The area of Circle is: " + area);
    // }


    // second part (branches and Loops)

    public static void branching(int m, int n)
    {
        if (m + n > 10)
        {
            Console.WriteLine("The Answer of a+b Is greater than 10");
        }
    }
    public static void ifElse1(int m, int n)
    {
        if (m + n > 10)
        {
            Console.WriteLine("The Answer of a+b Is greater than 10");
        }
        else
        {
            Console.WriteLine("The Answer of a+b Is not greater than 10");
        }
    }
    public static void compare1(int m, int n, int p)
    {
        if ((m + n + p > 10) && (m == n))
        {
            Console.WriteLine("The Answer of a+b+c Is greater than 10");
            Console.WriteLine("And the first number is equal to the second number");
        }
        else
        {
            Console.WriteLine("The Answer of a+b Is not greater than 10");
            Console.WriteLine("And the first number is not equal to the second number");
        }
    }
    public static void compare2(int m, int n, int p)
    {
        if ((m + n + p > 10) || (m == n))
        {
            Console.WriteLine("The Answer of a+b+c Is greater than 10");
            Console.WriteLine("Or the first number is equal to the second number");
        }
        else
        {
            Console.WriteLine("The Answer of a+b Is not greater than 10");
            Console.WriteLine("Or the first number is not equal to the second number");
        }
    }

    public static void whileLoop()
    {
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine("The Counter round is :" + counter);
            counter++;
        }
    }
    public static void doWhileLoop()
    {
        int counter = 0;
        do
        {
            Console.WriteLine("The Counter round is :" + counter);
            counter++;
        } while (counter < 10);
    }
    public static void forLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello world !That is  :" + i + "times!");
        }
    }
    public static void nestedLoop()
    {
        for (int row = 1; row < 6; row++)
        {
            for (char col = 'a'; col <'i';col++){
                Console.WriteLine($"The Cell is suggested that ({row},{col})");
            }
        }
    }

    public static void isDivisibleBy3(){
        int sum = 0;
        for (int number= 0; number<18;number++){
            if(number%3==0){
                sum+=number;
            }
        }
        Console.WriteLine($"The sum is: {sum} ");
    }

}

