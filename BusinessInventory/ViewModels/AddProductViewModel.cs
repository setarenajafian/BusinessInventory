using BusinessInventory.Models;
using BusinessInventory.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BusinessInventory.ViewModels;

public partial class AddProductViewModel : ObservableObject
{
    private readonly ProductService _productService;

    [ObservableProperty]
    private string name = string.Empty;

    [ObservableProperty]
    private string barcode = string.Empty;

    [ObservableProperty]
    private decimal price;

    [ObservableProperty]
    private int quantity;

    [ObservableProperty]
    private int minimumStock;

    [ObservableProperty]
    private string description = string.Empty;

    public AddProductViewModel(ProductService productService)
    {
        _productService = productService;
    }

    [RelayCommand]
    private async Task SaveAsync()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                await Application.Current!.Windows[0].Page!
                    .DisplayAlert(
                        "Validation",
                        "Product name is required.",
                        "OK");

                return;
            }

            if (string.IsNullOrWhiteSpace(Barcode))
            {
                await Application.Current!.Windows[0].Page!
                    .DisplayAlert(
                        "Validation",
                        "Barcode is required.",
                        "OK");

                return;
            }

            var product = new Product
            {
                Name = Name,
                Barcode = Barcode,
                Price = Price,
                Quantity = Quantity,
                MinimumStock = MinimumStock,
                Description = Description
            };

            await _productService.AddAsync(product);

            await Application.Current!.Windows[0].Page!
                .DisplayAlert(
                    "Success",
                    "Product saved successfully.",
                    "OK");

            // پاک کردن فرم
            Name = string.Empty;
            Barcode = string.Empty;
            Description = string.Empty;
            Price = 0;
            Quantity = 0;
            MinimumStock = 0;

            // برگشت به صفحه محصولات
            await Application.Current!.Windows[0].Page!
                .Navigation
                .PopAsync();
        }
        catch (Exception ex)
        {
            await Application.Current!.Windows[0].Page!
                .DisplayAlert(
                    "Error",
                    ex.Message,
                    "OK");
        }
    }
}