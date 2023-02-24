using ExemploCQRS.Application.Commands.GetUserModules.Handle.Result;
using MediatR;

namespace ExemploCQRS.Application.Commands.GetUserModules.Handle
{
    public class GetUserModuleHandle : IRequestHandler<GetUserModule, UserModuleResult>
    {
        public async Task<UserModuleResult> Handle(GetUserModule request,
            CancellationToken cancellationToken)
        {
            var user = new User
            {
                CPF = "",
                Email = "",
                Name = ""
            };
            var function = new Function
            {
                Cod = "1",
                Name = "XXXX"
            };
            var module = new Module
            {
                Cod = "A",
                Name = "ZZZZZ",
                Functions = new List<Function>() { function }
            };
            var result = new UserModuleResult { User = user, Modules = new List<Module>() { module } };
            return await Task.FromResult(result);
        }
    }
}
