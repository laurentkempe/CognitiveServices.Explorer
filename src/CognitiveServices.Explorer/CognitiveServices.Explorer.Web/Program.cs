﻿using Microsoft.AspNetCore.Blazor.Hosting;
using System.Threading.Tasks;

namespace CognitiveServices.Explorer.Web
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            // I prefer this setup to be separate from Program.cs just like regular ASP.NET web app.
            new Startup().ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }
    }
}
