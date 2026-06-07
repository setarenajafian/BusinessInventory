using BusinessInventory.ViewModels;

namespace BusinessInventory.Views;

public partial class AddProductPage : ContentPage
{
	public AddProductPage(AddProductViewModel vm)
	{
        InitializeComponent();

        BindingContext = vm;
    }
    private async void OnScanBarcodeClicked(
    object sender,
    EventArgs e)
    {
        var page =
            IPlatformApplication.Current!
            .Services
            .GetRequiredService<BarcodeScannerPage>();

        await Navigation.PushAsync(page);
    }
}