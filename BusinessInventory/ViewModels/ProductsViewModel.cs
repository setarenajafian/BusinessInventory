using BusinessInventory.Models;
using BusinessInventory.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BusinessInventory.ViewModels;

public partial class ProductsViewModel : ObservableObject
{
    private readonly ProductService _productService;

    [ObservableProperty]
    private string searchText = string.Empty;

    public ObservableCollection<Product> Products { get; } = new();

    private List<Product> _allProducts = new();

    [ObservableProperty]
    private int totalProducts;

    [ObservableProperty]
    private int lowStockProducts;

    [ObservableProperty]
    private decimal totalInventoryValue;

    public ProductsViewModel(ProductService productService)
    {
        _productService = productService;
    }

    partial void OnSearchTextChanged(string value)
    {
        Products.Clear();

        var filteredProducts = _allProducts
            .Where(x =>
                x.Name.Contains(
                    value,
                    StringComparison.OrdinalIgnoreCase)
                ||
                x.Barcode.Contains(
                    value,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();

        foreach (var product in filteredProducts)
        {
            Products.Add(product);
        }
    }

    [RelayCommand]
    public async Task LoadProductsAsync()
    {
        Products.Clear();

        _allProducts =
            await _productService.GetAllAsync();

        TotalProducts = _allProducts.Count;

        LowStockProducts =
            _allProducts.Count(x => x.IsLowStock);

        TotalInventoryValue =
            _allProducts.Sum(x => x.Price * x.Quantity);

        foreach (var product in _allProducts)
        {
            Products.Add(product);
        }
    }
}