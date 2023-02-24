using FluentValidation;

namespace ExemploCQRS.Application.Commands.GetUserModules.Validation
{
    public class GetUserModuleValidator: AbstractValidator<GetUserModule>
    {
        public GetUserModuleValidator()
        {
            RuleFor(x => x.Email).Custom((email, context) =>
            {
                if (string.IsNullOrEmpty(email))
                    context.AddFailure("Email Obrigatório");
            });
        }
    }
}
