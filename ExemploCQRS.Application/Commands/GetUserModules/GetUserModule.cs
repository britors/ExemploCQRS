using ExemploCQRS.Application.Commands.GetUserModules.Handle.Result;
using MediatR;

namespace ExemploCQRS.Application.Commands.GetUserModules
{
    public class GetUserModule: IRequest<UserModuleResult>
    {
        public string? Email { get; set; }
    }
}
