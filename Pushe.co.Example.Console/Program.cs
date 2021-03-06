﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Pushe.co.Example.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Pushe.co!");

            Task.Run(() => SendPusheNoty());

            System.Console.ReadLine();

        }




        /// <summary>
        /// 
        /// </summary>
        private static async Task SendPusheNoty()
        {
                var serviceProvider = GetServiceProvider();
            
                var pusheService = serviceProvider.GetRequiredService<IPusheService>();

                var push = new PusheJsonModel
                {
                    Applications=new string[] {"my_app_name" },
                    Notification = new Notification
                    {
                        Title = "test by console app",
                        Content = "this is a test by console app",

                    },
                    Filter = new Filter
                    {
                        //by pushe id
                        Pushe_Id = new string[] { "pid_31b1-33d3-30" },
                    }
                };

                await pusheService.SendAsync(push);

        }



        /// <summary>
        /// 
        /// </summary>
        private static IServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddOptions();

            services.AddPushe(options =>
            {
                options.AccessToken = "YOUR_PUSHE_ACCESS_TOKEN";
            });

            return services.BuildServiceProvider();
        }
    }


}
