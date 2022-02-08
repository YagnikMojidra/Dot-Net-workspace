using System;
//Properties with backing fields
//print  Time period
class TimePeriod
{
    private double seconds;

    public double Hours
    {
        get { return seconds / 3600; }
        set
        {
            if (value < 0 || value > 24)
                throw new ArgumentOutOfRangeException(
                      $"{nameof(value)} must be between 0 and 24.");

            seconds = value * 3600;
        }
    }
}
//Expression body definitions
// print name
public class Person
{
    private string firstName;
    private string lastName;

    public Person(string first, string last)
    {
        firstName = first;
        lastName = last;
    }

    public string Name => $"{firstName} {lastName}";
}

//Expression body definitions
public class SaleItem
{
    string _name;
    decimal _cost;

    public SaleItem(string name, decimal cost)
    {
        _name = name;
        _cost = cost;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public decimal Price
    {
        get => _cost;
        set => _cost = value;
    }
}
//Auto-implemented properties
public class SaleItem2
{
    public string Name2
    { get; set; }

    public decimal Price2
    { get; set; }
}

//Using indexers
public class TempRecord
{
    // Array of temperature values
    float[] temps = new float[10]
    {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
    };

    // To enable client code to validate input
    // when accessing your indexer.
    public int Length => temps.Length;
    
    // Indexer declaration.
    // If index is out of range, the temps array will throw the exception.
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }
}
class Program
{
    static void Main()
    {
        TimePeriod t = new TimePeriod();
        t.Hours = 24;
        Console.WriteLine($"Time in hours is: {t.Hours}");


        var person = new Person("Yagnik", "Mojidra");
        Console.WriteLine(person.Name);

        var item = new SaleItem("Shoes", 19.95m);
        Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");

        var item2 = new SaleItem2 { Name2 = "Shoes", Price2 = 19.95m };
        Console.WriteLine($"{item2.Name2}: sells for {item2.Price2:C2}");
        
        var tempRecord = new TempRecord();
        // Use the indexer's set accessor
        tempRecord[3] = 58.3F;
        tempRecord[5] = 60.1F;
        tempRecord[8] = 62.1F;
        // Use the indexer's get accessor
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Element No {i} = {tempRecord[i]}");
        }
    }
}
