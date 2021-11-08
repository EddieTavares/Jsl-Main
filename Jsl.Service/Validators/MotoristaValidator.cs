using FluentValidation;
using Jsl.Domain.Entities;

namespace Jsl.Service.Validators
{
    public class MotoristaValidator : AbstractValidator<Motorista>
    {
        public MotoristaValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe o nome do motorista.")
                .NotNull().WithMessage("Informe o nome do motorista.");
            
            RuleFor(c => c.Sobrenome)
                .NotEmpty().WithMessage("Informe o nome do Sobrenome do motorista..")
                .NotNull().WithMessage("Informe o nome do Sobrenome do motorista..");

            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("Informe a rua/logradouro do motorista.")
                .NotNull().WithMessage("Please a rua/logradouro the email.");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("Informe o numero do motorista.")
                .NotNull().WithMessage("Informe o numero do motorista.");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("Informe o bairro do motorista.")
                .NotNull().WithMessage("Informe o bairro do motorista.");

            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("Informe a cidade do motorista.")
                .NotNull().WithMessage("Informe a cidade do motorista.");

            RuleFor(c => c.UF)
                .NotEmpty().WithMessage("Informe o estado do motorista.")
                .NotNull().WithMessage("Informe o estado do motorista.");

            RuleFor(c => c.CEP)
                .NotEmpty().WithMessage("Informe o CEP do motorista.")
                .NotNull().WithMessage("Informe o CEP do motorista.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Informe o telefone do motorista.")
                .NotNull().WithMessage("Informe o telefone do motorista.");

            RuleFor(c => c.Marca)
                .NotEmpty().WithMessage("Informe a marca do caminhão do motorista.")
                .NotNull().WithMessage("Informe a marca do caminhão do motorista.");

            RuleFor(c => c.Modelo)
                .NotEmpty().WithMessage("Informe o modelo do caminhão do motorista.")
                .NotNull().WithMessage("Informe o modelo do caminhão do motorista.");

            RuleFor(c => c.Placa)
                .NotEmpty().WithMessage("Informe a placa do caminhão do motorista.")
                .NotNull().WithMessage("Informe a placa do caminhão do motorista.");

            RuleFor(c => c.Eixos)
                .NotEmpty().WithMessage("Informe o número de eixos do caminhão do motorista.")
                .NotNull().WithMessage("Informe o número de eixos do caminhão do motorista.");
        }
    }
}
