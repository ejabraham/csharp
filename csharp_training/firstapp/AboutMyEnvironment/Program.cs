namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
        int x = 6;
        double y = .5567;
        var s = 0x777;
        Console.WriteLine(s);
    }
}
