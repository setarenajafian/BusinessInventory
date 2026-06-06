using BusinessInventory.Models;
using BusinessInventory.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BusinessInventory.ViewModels;

public partial class EditProductViewModel : ObservableObject
{
    private readonly ProductService _productService;
    private Product _product = null!;

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

    public EditProductViewModel(ProductService productService)
    {
        _productService = productService;
    }

    public void LoadProduct(Product product)
    {
        _product = product;

        Name = product.Name;
        Barcode = product.Barcode;
        Price = product.Price;
        Quantity = product.Quantity;
        MinimumStock = product.MinimumStock;
        Description = product.Description;
    }

    [RelayCommand]
    private async Task UpdateAsync()
    {
        _product.Name = Name;
        _product.Barcode = Barcode;
        _product.Price = Price;
        _product.Quantity = Quantity;
        _product.MinimumStock = MinimumStock;
        _product.Description = Description;

        await _productService.UpdateAsync(_product);

        await Application.Current!.Windows[0].Page!
            .DisplayAlert(
                "Success",
                "Product updated successfully.",
                "OK");

        await Application.Current!.Windows[0].Page!
            .Navigation
            .PopAsync();
    }
}