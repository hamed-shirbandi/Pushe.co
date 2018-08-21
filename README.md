# What is this ?

Simple library to send push notification by [pushe.co](https://www.pushe.co)

# Install via NuGet

To install Pushe.co, run the following command in the Package Manager Console
```code
pm> Install-Package Pushe.co
```
You can also view the [package page](https://www.nuget.org/packages/Pushe.co) on NuGet.

# How to use ?

1- install package from nuget

2- add required services Startup class as below :
```code
               services.AddPushe(options=>
                {
                  options.AccessToken = "YOUR_PUSHE_ACCESS_TOKEN";
                  
                 });
```
3- send push notification by using IPusheService:
```code
               var pusheService = serviceProvider.GetRequiredService<IPusheService>();

                var push = new PusheJsonModel
                {
                    Applications = new string[] { "ir.My.app" },
                    Notification = new Notification
                    {
                        Title = "test by console app",
                        Content = "this is a test by console app",

                    },
                    Filter = new Filter
                    {
                        //by pushe id
                        IMEI = new string[] { "pid_31b1-33d3-30" },
                    }
                };

                await pusheService.SendAsync(push);
```

See more example in source.

# To Do

-Add MVC example
