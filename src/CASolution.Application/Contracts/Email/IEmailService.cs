using System.Threading.Tasks;

namespace CASolution.Application.Contracts.Email
{
    public interface IEmailService
    {
        Task SendAsync(string recipient, string subject, string body);

    }
}
