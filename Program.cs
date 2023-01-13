namespace trang.net;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{Environment.Version} {Environment.OSVersion}");
        com.thaiopensource.relaxng.translate.Driver.main(args);
    }
}
