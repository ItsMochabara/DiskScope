using System;
using DiskScope.App.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DiskScope.App.Services;

public static class AppServices
{
    public static IServiceProvider Configure()
    {
        var services = new ServiceCollection();

        services.AddSingleton<MainViewModel>();

        return services.BuildServiceProvider();
    }
}