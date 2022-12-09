using Core.Entities.Concrete;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
