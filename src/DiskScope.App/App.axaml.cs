using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DiskScope.App.Services;
using DiskScope.App.ViewModels;
using DiskScope.App.Views;
using Microsoft.Extensions.DependencyInjection;

namespace DiskScope.App;

public partial class App : Application
{
    private IServiceProvider? _services;

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        _services = AppServices.Configure();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = _services.GetRequiredService<MainViewModel>()
            };

            desktop.Exit += (_, _) =>
            {
                if (_services is IDisposable disposable)
                {
                    disposable.Dispose();
                }
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}