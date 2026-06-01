using BusinessInventory.Views;

namespace BusinessInventory;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
            nameof(ProductsPage),
            typeof(ProductsPage));
    }
}
