[Flags]
public enum Days

{

    None = 0b_0000_0000, // 0

    Monday = 0b_0000_0001, // 1

    Tuesday = 0b_0000_0010, // 2

    Wednesday = 0b_0000_0100, // 4

    Thursday = 0b_0000_1000, // 8

    Friday = 0b_0001_0000, // 16

    Saturday = 0b_0010_0000, // 32

    Sunday = 0b_0100_0000, // 64

    Weekend = Saturday | Sunday

}

public class Flgs
{
    public static void Main()
    {

        Days mettingDays = Days.Monday | Days.Friday | Days.Wednesday;
        Console.WriteLine(mettingDays.ToString());

        Days workingForHomeDays = Days.Thursday | Days.Friday;
        Console.WriteLine($"Join a meeting By Phone on: {mettingDays & workingForHomeDays}");

        bool isMeetingOnTuesdays = (mettingDays & workingForHomeDays) == Days.Tuesday;
        Console.WriteLine($"Is there a meeting on the Tuesday? {isMeetingOnTuesdays}");

        var a = (Days)37;
        Console.WriteLine(a.ToString());

    }
}