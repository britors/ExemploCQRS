namespace ExemploCQRS.Infra.Communication.Interfaces
{
    public interface IHttpRequest<TRequest, TResponse> 
        where TResponse : class 
        where TRequest : class
    {
        Task<TResponse> Get(string endpoint,
            TRequest? request = null,
            IList<Header>? headers = null);

        Task<TResponse> Post(string endpoint,
            TRequest? request = null,
            IList<Header>? headers = null);

        Task<TResponse> Put(string endpoint,
            TRequest? request = null,
            IList<Header>? headers = null);

        Task<TResponse> Delete(string endpoint,
            TRequest? request = null,
            IList<Header>? headers = null);
    }
}