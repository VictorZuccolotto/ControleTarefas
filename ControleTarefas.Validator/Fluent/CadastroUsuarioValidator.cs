using ControleTarefas.Entity.Enum;
using ControleTarefas.Entity.Model;
using ControleTarefas.Utils.Messages;
using FluentValidation;

namespace ControleTarefas.Validador.Fluent
{
    public class CadastroUsuarioValidator : AbstractValidator<CadastroUsuarioModel>
    {
        public CadastroUsuarioValidator()
        {
            RuleFor(t => t.Nome)
                .NotNull().WithMessage(string.Format(BusinessMessages.CampoObrigatorio, "Nome"))
                .NotEmpty().WithMessage(string.Format(BusinessMessages.CampoObrigatorio, "Nome"));

            RuleFor(t => t.Email).EmailAddress().WithMessage(string.Format(BusinessMessages.CampoInvalido, "Email"))
                .NotNull().WithMessage(string.Format(BusinessMessages.CampoObrigatorio, "Email"))
                .NotEmpty().WithMessage(string.Format(BusinessMessages.CampoObrigatorio, "Email"));

            //RuleFor(t => t.Perfil)
            //    .Must(perfil => Enum.IsDefined(typeof(PerfilEnum), perfil)).WithMessage(string.Format(BusinessMessages.CampoInvalido, "Perfil"))
            //    .NotNull().WithMessage(string.Format(BusinessMessages.CampoObrigatorio, "Perfil"));
        }
    }
}