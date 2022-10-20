using ReactiveUI;
using RoutingExample.ViewModels;
using RoutingExample.Views;
using System;
using Splat;


namespace RoutingExample
{
    public class AppViewLocator : ReactiveUI.IViewLocator
    {
        
        IViewFor? IViewLocator.ResolveView<T>(T viewModel, string? contract) => viewModel switch
        {
            FirstViewModel context => new FirstView { DataContext = context },
            _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
        };
    }
}
