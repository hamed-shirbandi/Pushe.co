using System.Threading.Tasks;

namespace Pushe.co
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPusheService
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pusheJsonModel"></param>
        /// <returns></returns>
        Task SendAsync(PusheJsonModel pusheJsonModel);
    }
}