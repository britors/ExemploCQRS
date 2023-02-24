using ExemploCQRS.Infra.Communication.Interfaces;

namespace ExemploCQRS.Infra.Communication
{
    public class HttpRequest<TRequest, TResponse> : IHttpRequest<TRequest, TResponse>
        where TResponse : class
        where TRequest : class
    {
        public async Task<TResponse> Delete(string endpoint, TRequest? request = null, IList<Header>? headers = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TResponse> Get(string endpoint, TRequest? request = null, IList<Header>? headers = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TResponse> Post(string endpoint, TRequest? request = null, IList<Header>? headers = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TResponse> Put(string endpoint, TRequest? request = null, IList<Header>? headers = null)
        {
            throw new NotImplementedException();
        }
    }
}
