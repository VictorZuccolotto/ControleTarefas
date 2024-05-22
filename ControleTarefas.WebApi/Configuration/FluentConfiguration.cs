using ControleTarefas.Validador.Fluent;
using FluentValidation.AspNetCore;

namespace ControleTarefas.WebApi.Configuration
{
    public static class FluentConfiguration
    {
        public static void AddFluentConfiguration(this IServiceCollection services)
        {
            services.AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<CadastroTarefaValidator>());
            services.AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<CadastroUsuarioValidator>());
        }
    }
}