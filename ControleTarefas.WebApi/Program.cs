using ControleTarefas.Api;
using log4net.Config;
using log4net;
using Microsoft.AspNetCore;
using System.Reflection;

namespace ControleTarefas.WebApi
{
    public static class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));

        public static void Main(string[] args)
        {
            try
            {
                var logRepository = LogManager.GetRepository(Assembly.GetCallingAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

                _log.Info("Iniciando API");
                var webHost = WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
                webHost.Build().Run();
            }catch(Exception ex)
            {
                _log.Error("Erro Fatal", ex);
                throw;
            }

        }
    }
}