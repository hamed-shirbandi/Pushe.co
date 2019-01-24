# What is this ?

Simple library to send push notification by [pushe.co](https://www.pushe.co)

[Article in persian](http://www.codeblock.ir/article/43/%D8%A7%D8%B1%D8%B3%D8%A7%D9%84-push-notification-%D8%A7%D8%B2-%D8%B7%D8%B1%DB%8C%D9%82-%D8%B3%D8%B1%D9%88%DB%8C%D8%B3-%D9%BE%D9%88%D8%B4%D9%87-%D8%AF%D8%B1-%D8%A8%D8%B1%D9%86%D8%A7%D9%85%D9%87-%D9%87%D8%A7%DB%8C-%D9%85%D8%A8%D8%AA%D9%86%DB%8C-%D8%A8%D8%B1--net-core)

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
                  options.Applications = "APP_Name1,APP_Name2";
                  
                 });
```
3- send push notification by using IPusheService:
```code
               var pusheService = serviceProvider.GetRequiredService<IPusheService>();

                var push = new PusheJsonModel
                {
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
```

See more example in source.

# To Do

-Add MVC example
