class Program
{
    static void Main(string[] args)
    {
        Task.Run(async () =>
        {
            Barman barm = new Barman();
            Task work = barm.HotSnack(); 
            barm.CreateCoctel();
            await work;
        }).GetAwaiter().GetResult();
        
    }
}

public class Barman
{
    public async Task HotSnack()
    {
        Console.WriteLine("Snack to horn");
        HttpClient client = new HttpClient();
        await client.GetAsync("http://google.com");
        Console.WriteLine("Snack out from horn");
        
    }

    public void CreateCoctel()
    {
        Console.WriteLine("Creating Coctel...");
        Thread.Sleep(5000);
        Console.WriteLine("Finished Coctel");
    }
}