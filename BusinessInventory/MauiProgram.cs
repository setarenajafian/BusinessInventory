using Microsoft.Extensions.Logging;
using BusinessInventory.Services;
using BusinessInventory.ViewModels;
using BusinessInventory.Views;
using ZXing.Net.Maui.Controls;

namespace BusinessInventory;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseBarcodeReader()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<ProductsViewModel>();
        builder.Services.AddSingleton<ProductsPage>();
        builder.Services.AddSingleton<DatabaseService>();
        builder.Services.AddSingleton<ProductService>();
        builder.Services.AddSingleton<AddProductViewModel>();
        builder.Services.AddSingleton<AddProductPage>();
        builder.Services.AddSingleton<EditProductViewModel>();
        builder.Services.AddTransient<EditProductPage>();
        builder.Services.AddTransient<BarcodeScannerPage>();

        return builder.Build();
    }
}
