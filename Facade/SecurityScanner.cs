namespace Facade;

public class SecurityScanner
{
    public IEnumerable<string> SecurityScan(string githubUrl)
    {
        Console.WriteLine("Security Scan");

        return new List<string>() { "security error1" };
    }
}