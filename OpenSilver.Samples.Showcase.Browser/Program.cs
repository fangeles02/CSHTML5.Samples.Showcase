﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using DotNetForHtml5;

namespace OpenSilver.Samples.Showcase.Browser
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            Cshtml5Initializer.Initialize();
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var host = builder.Build();
            await host.RunAsync();
        }

        public static void RunApplication()
        {
            Application.RunApplication(() =>
            {
                var app = new CSHTML5.Samples.Showcase.App();
            });
        }
    }
}