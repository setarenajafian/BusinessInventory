using BusinessInventory.Models;
using BusinessInventory.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BusinessInventory.ViewModels;

public partial class ProductsViewModel : ObservableObject
{
    private readonly ProductService _productService;

    public ObservableCollection<Product> Products { get; } = new();

    public ProductsViewModel(ProductService productService)
    {
        _productService = productService;
    }

    [RelayCommand]
    public async Task LoadProductsAsync()
    {
        Products.Clear();

        var products =
        await _productService.GetAllAsync();

        foreach (var product in products)
        {
            Products.Add(product);
        }
    }

}
