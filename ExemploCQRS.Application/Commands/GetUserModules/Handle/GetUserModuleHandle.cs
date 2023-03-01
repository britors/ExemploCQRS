using ExemploCQRS.Application.Commands.GetUserModules.Handle.Result;
using MediatR;

namespace ExemploCQRS.Application.Commands.GetUserModules.Handle
{
    public class GetUserModuleHandle : IRequestHandler<GetUserModule, UserModuleResult>
    {
        public Task<UserModuleResult> Handle(GetUserModule request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
