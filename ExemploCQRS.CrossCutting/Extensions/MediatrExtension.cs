using ExemploCQRS.Application.Commands.GetUserModules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace ExemploCQRS.CrossCutting.Extensions
{
    public static class MediatrExtension
    {
        public static void AddMediatRApi(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetUserModule));
        }
    }
}
