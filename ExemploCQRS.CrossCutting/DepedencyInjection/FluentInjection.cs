using ExemploCQRS.Application.Commands.GetUserModules;
using ExemploCQRS.Application.Commands.GetUserModules.Validation;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploCQRS.CrossCutting.DepedencyInjection
{
    public static class FluentInjection
    {
        public static void Build(IServiceCollection services)
        {
            services.AddScoped<IValidator<GetUserModule>, GetUserModuleValidator>();
        }
    }
}
