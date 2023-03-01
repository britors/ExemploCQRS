namespace ExemploCQRS.Application.Commands.GetUserModules.Handle.Result
{
    public class UserResult
    {
        public string CPF { get; }
        public string Name { get; }
        public string Email { get; }

        public UserResult(string cpf, string name, string email)
        {
            CPF = cpf;
            Name = name;
            Email = email;
        }
    }
}
