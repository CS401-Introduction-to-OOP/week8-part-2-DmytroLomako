namespace Week8.Variant1;


class Program
{
    static void Main(string[] args)
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        
        // TODO:
        // 1. Add resources to manager
        // 2. Open all resources
        // 3. Demonstrate using with one disposable resource
        // 4. Close all resources
        Console.WriteLine("Done.");
    }
}