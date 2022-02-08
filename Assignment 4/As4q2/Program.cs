using System;
// public DateOnly rdate { get;  }
public class Employee
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public double monthlySalary
    {
        get;
        set;
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} {monthlySalary}";
    }

    public double giveRaise(double msalary)
    {
        return msalary += msalary * 0.1;
    }
}
public class permanentEmployee : Employee
{
    public double hra { get; set; }
    public double da { get; set; }
    public double pf { get; set; }

    public override string ToString()
    {
        return $"{firstName}  \t {lastName}  \t {monthlySalary}  \t {hra}  \t {da}  \t {pf}";
    }
    public double giveRaise(double msalary, double hra, double da, double pf)
    {
        return msalary =msalary+ msalary*0.01 + hra + da + pf;
    }
}
class TestEmployee
{
    static void Main()
    {
        //for question1
            var emp1 = new Employee { firstName = "Yagnik", lastName = "Mojidra", monthlySalary = 24000 };
            var emp2 = new Employee { firstName = "Utsav", lastName = "Patel", monthlySalary = 34000 };
            if (emp1.monthlySalary < 0 || emp2.monthlySalary < 0)
            {
                Console.WriteLine("Salary should be greater than zero.");
                emp1.monthlySalary = 0;
                emp2.monthlySalary = 0;
                Console.WriteLine($"{emp1.firstName} {emp1.lastName} your yearly salary is : {emp1.monthlySalary} .");
                Console.WriteLine($"{emp2.firstName} {emp2.lastName} your yearly salary is : {emp2.monthlySalary} .");
            }
            else
            {
                Console.WriteLine($"{emp1.firstName} {emp1.lastName} your yearly salary is : {emp1.monthlySalary * 12} .");
                Console.WriteLine($"{emp2.firstName} {emp2.lastName} your yearly salary is : {emp2.monthlySalary * 12} .");
            }
            Console.WriteLine("Here we use ToString Method.");
            Console.WriteLine("FirstName\tLastName\tMonthlySalary");

            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp2.ToString());

            Console.WriteLine("Our employees get 10% increment in salary.");
            emp1.giveRaise(emp1.monthlySalary);
            emp2.giveRaise(emp2.monthlySalary);
            Console.WriteLine($"{emp1.firstName} {emp1.lastName} your yearly salary with increment is : {emp1.monthlySalary * 12} .");
            Console.WriteLine($"{emp2.firstName} {emp2.lastName} your yearly salary with increment is : {emp2.monthlySalary * 12} .");

        //for question2
        //here we use method overloading and hiding
        var emp3 = new permanentEmployee { firstName = "Yagnik", lastName = "Mojidra", monthlySalary = 24000, hra = 24000 * 0.08, da = 24000 * .06, pf = 24000 * 0.02 };
        DateOnly jdate = new DateOnly(2022, 2, 5);
        Console.WriteLine("Here we use ToString Method.");
        Console.WriteLine("FirstName\tLastName\tMonthlySalary\tHRA\tDA\tPF");
        Console.WriteLine(emp3.ToString());
        Console.WriteLine("This employee Joing date is " + jdate.ToString());
        DateOnly rdate = new DateOnly(2026, 2, 5);
        Console.WriteLine("This employee Expected Retirement date is " + rdate.ToString());
        // emp3.giveRaise(emp3.monthlySalary, emp3.hra, emp3.da, emp3.pf);
        Console.WriteLine("Our Employee Final incremented salary is given below:: ");
        Console.WriteLine("Our employee final salary is :" +  emp3.giveRaise(emp3.monthlySalary, emp3.hra, emp3.da, emp3.pf));
    }
}

