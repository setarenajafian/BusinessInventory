
using BusinessInventory.Models;
using BusinessInventory.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ZXing.QrCode.Internal;


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
        var product = new Product
        {
            Name = name,
            Barcode = barcode,
            Price = price,
            Quantity = quantity,
            MinimumStock = minimumStock,
            Description = description
        };

        await _productService.AddAsync(product);

        await Shell.Current.DisplayAlert(
            "Success",
            "Product saved successfully",
            "OK");
    }
}
