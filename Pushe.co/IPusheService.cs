using System.Threading.Tasks;

namespace Pushe.co
{
    public interface IPusheService
    {
        void Send(PusheJsonModel pusheJsonModel);
        Task SendAsync(PusheJsonModel pusheJsonModel);
    }
}