using BusinessInventory.Views;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessInventory;

public partial class App : Application
{

    public App()
    {
        InitializeComponent();
    }


    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(
         new NavigationPage(
         IPlatformApplication.Current!
         .Services
         .GetRequiredService<ProductsPage>()));
    }
}