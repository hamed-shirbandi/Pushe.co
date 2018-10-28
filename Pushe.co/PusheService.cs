using Pushe.co.Helpers;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Pushe.co
{

    /// <summary>
    /// 
    /// </summary>
    public class PusheService : IPusheService
    {
        #region Fields

        private readonly PusheOptions _options;
        private const string _apiUrl = "https://panel.pushe.co/api/v1/notifications/";

        #endregion

        #region Ctor

        public PusheService(IOptions<PusheOptions> options)
        {
            _options = options != null ? options.Value : throw new ArgumentNullException(nameof(options));

        }

        #endregion

        #region Public Methods




        /// <summary>
        /// 
        /// </summary>
        public async Task SendAsync(PusheJsonModel pusheJsonModel)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver()
            };
            var myContent = JsonConvert.SerializeObject(pusheJsonModel, Formatting.Indented, settings);
            var buffer = Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(_apiUrl),
                    Content = byteContent
                };

                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                request.Headers.Add("Authorization", $"Token {_options.AccessToken}");
                request.Headers.Add("Accept", "application/json");
                var response = await client.SendAsync(request);
                var responseBody = await response.Content.ReadAsStringAsync();
            }
        }



        #endregion

        #region Private Methods



        #endregion


    }
}
