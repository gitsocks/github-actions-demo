namespace GithubActionsDemo;

public static class Program
{
    public static void Main(string[] args)
    {
        var environment = Environment.GetEnvironmentVariable("DEV_ENVIRONMENT");
        Console.WriteLine("DEV_ENVIRONMENT: {0}", environment);
    }
}
