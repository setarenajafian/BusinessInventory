using ZXing.Net.Maui;

namespace BusinessInventory.Views;

public partial class BarcodeScannerPage : ContentPage
{
	public BarcodeScannerPage()
	{
		InitializeComponent();
	}

    private async void CameraView_BarcodesDetected(
       object sender,
       BarcodeDetectionEventArgs e)
    {
        var barcode =
            e.Results.FirstOrDefault()?.Value;

        if (string.IsNullOrWhiteSpace(barcode))
            return;

        await MainThread.InvokeOnMainThreadAsync(async () =>
        {
            await DisplayAlert(
                "Barcode",
                barcode,
                "OK");
        });
    }
}