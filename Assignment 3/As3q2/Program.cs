using System;
class Problem2Check
{
    public static bool isDecl(string m)
    {
        int x = m.Count();
        return m[x - 1] == '.';
    }
    public static bool isInter(string m)
    {
        int x = m.Count();
        return m[x - 1] == '?';
    }
    public static bool isExa(string m)
    {
        int x = m.Count();
        return m[x - 1] == '!';
    }
}
class As3q2
{

    public static void Main()
    {

        // this is second question part1
        void Pro21()
        {
            Console.WriteLine("This question is first part of second question");
            // Label l1=new Label();
            Console.WriteLine("Enter the StringName");
            String name = Console.ReadLine();

            int c = name.Count();
            Console.WriteLine($"The String Length is {c}");
        }
        Pro21();

        // this is second question part 2
        void Pro22()
        {
            Console.WriteLine("This question is second part of second question");
            Console.WriteLine("Enter the Sentence");
            String name = Console.ReadLine();

            if (Problem2Check.isDecl(name))
            {
                Console.WriteLine(" It is Declarative Sentence.");
            }
            else if (Problem2Check.isInter(name))
            {
                Console.WriteLine(" It is Interrogatory Sentence.");
            }
            else if (Problem2Check.isExa(name))
            {
                Console.WriteLine(" It is Exclamation Sentence.");
            }
            else
            {
                Console.WriteLine(" It is not a Sentence.");
            }

        }
        Pro22();


        // this is second question part 3
        void Pro23()
        {
            Console.WriteLine("This question is third part of second question");
            Console.WriteLine("Enter the name (Must having first name and last name)");
            String name = Console.ReadLine();

            String[] ar = name.Split();
            Console.WriteLine($"You have entered name '{ar[1]},{ar[0]}'");
        }
        Pro23();

        // this is second question part 4
        void Pro24()
        {
            Console.WriteLine("This question is Fourth part of second question");
            Console.WriteLine("Enter the name :");
            String name = Console.ReadLine();
            String[] ar = name.Split();
            if (ar.Length == 1)
            {
                Console.WriteLine($"You have entered name : '{ar[0]}' ");
            }
            else
            {
                Console.WriteLine($"You have entered name : '{ar[1]}' ");
            }

        }
        Pro24();
    }



}
