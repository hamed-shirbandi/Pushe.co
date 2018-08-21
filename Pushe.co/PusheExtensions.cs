using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pushe.co
{

    /// <summary>
    /// 
    /// </summary>
   public static class PusheExtensions
    {



        /// <summary>
        /// 
        /// </summary>
        public static IServiceCollection AddPushe(this IServiceCollection services, Action<PusheOptions> setupAction)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            services.Configure(setupAction);
            services.TryAddSingleton<IPusheService, PusheService>();
            return services;
        }
    }
}
