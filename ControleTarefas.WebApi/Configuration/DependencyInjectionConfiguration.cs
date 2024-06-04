
using ControleTarefas.Repository;
using ControleTarefas.Repository.Interface.IRepositories;
using ControleTarefas.Repository.Repositories;
using ControleTarefas.Service.Interface.IServices;
using ControleTarefas.Service.Services;

namespace ControleTarefas.WebApi.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            InjectServices(services);
            InjectRepositories(services);

            services.AddScoped<ITransactionManager, TransactionManager>();
        }

        private static void InjectRepositories(IServiceCollection services)
        {
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        private static void InjectServices(IServiceCollection services)
        {
            services.AddScoped<ITarefaService, TarefaService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITarefaUserService, TarefaUserService>();
        }
    }
}
