using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        var server1 = SimulateServerResponse("Server1", cts.Token);
        var server2 = SimulateServerResponse("Server2", cts.Token);
        var server3 = SimulateServerResponse("Server3", cts.Token);

        var completed = await Task.WhenAny(server1, server2, server3);
        Console.WriteLine($"\nFastest response from: {completed.Result}");

        cts.Cancel();

        try
        {
            await Task.WhenAll(server1, server2, server3);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine(" Remaining server tasks were cancelled.");
        }
    }

    static async Task<string> SimulateServerResponse(string serverName, CancellationToken token)
    {
        try
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int delay = rand.Next(1000, 5000); 
            Console.WriteLine($"{serverName} will respond in {delay} ms");

            await Task.Delay(delay, token); 
            token.ThrowIfCancellationRequested();

            return serverName;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"{serverName} cancelled.");
            throw;
        }
    }
}
