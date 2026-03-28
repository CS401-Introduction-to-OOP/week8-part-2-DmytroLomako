namespace Week8.Variant1;


class Program
{
    static void Main(string[] args)
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();

        manager.Add(file);
        manager.Add(network);

        manager.OpenAll();

        using(var resource = new FileResource("temp_file")) 
        {
            resource.Open();
        }
        
        manager.CloseAll();

        Console.WriteLine("Done.");
    }
}