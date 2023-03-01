namespace ExemploCQRS.Application.Commands.GetUserModules.Handle.Result
{
    public sealed class UserModuleResult
    {
        public UserResult User { get; }
        public IList<ModuleResult> Modules { get; }

        public UserModuleResult(UserResult user, IList<ModuleResult> modules)
        {
            User = user;
            Modules = modules;
        }
    }
}
