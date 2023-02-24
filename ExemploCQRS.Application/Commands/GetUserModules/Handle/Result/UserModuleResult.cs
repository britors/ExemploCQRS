namespace ExemploCQRS.Application.Commands.GetUserModules.Handle.Result
{
    public sealed class UserModuleResult
    {
        public User User { get; set; }
        public IList<Module> Modules { get; set; }
    }


    public class User
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Module
    {
        public string Cod { get; set; }
        public string Name { get; set; }
        public IList<Function> Functions { get; set; }
    }

    public class Function
    {
        public string Cod { get; set; }
        public string Name { get; set; }
    }
}
