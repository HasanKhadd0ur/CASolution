using Ardalis.Result;
using System.Threading.Tasks;

namespace CASolution.Application.Contracts.Authentication
{
    public interface IAuthenticationService
    {
        public Task<Result<AuthenticationResult>> Login(string email, string password);
        public Task<Result<AuthenticationResult>> Register(string email, string userName, string password);


    }

}
