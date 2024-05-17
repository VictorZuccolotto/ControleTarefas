using ControleTarefas.Api;
using Microsoft.AspNetCore;

public static class Program
{

    public static void Main(string[] args)
    {
            var webHost = WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
            webHost.Build().Run();
    }
}
