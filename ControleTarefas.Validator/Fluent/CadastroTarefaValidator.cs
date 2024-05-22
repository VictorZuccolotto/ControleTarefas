using ControleTarefas.Entity.Model;
using ControleTarefas.Utils.Messages;
using FluentValidation;

namespace ControleTarefas.Validador.Fluent
{
    public class CadastroTarefaValidator : AbstractValidator<CadastroTarefaModel>
    {
        public CadastroTarefaValidator()
        {
            RuleFor(tarefa => tarefa.Titulo)
                .NotNull().WithMessage(string.Format(BusinessMessages.CampoObrigatorio, "Título"))
                .NotEmpty().WithMessage(string.Format(BusinessMessages.CampoObrigatorio, "Título"))
                .MinimumLength(5).WithMessage(string.Format(BusinessMessages.CampoTamanhoMinimo, "Título", 5))
                .MaximumLength(50).WithMessage(string.Format(BusinessMessages.CampoTamanhoMaximo, "Título", 50));
        }
    }
}