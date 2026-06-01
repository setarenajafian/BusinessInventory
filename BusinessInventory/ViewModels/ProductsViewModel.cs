using BusinessInventory.Models;
using BusinessInventory.Services;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BusinessInventory.ViewModels;

public partial class ProductsViewModel
{
    private readonly DatabaseService _databaseService;

    public ObservableCollection<Product> Products { get; } = new();

    public ProductsViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    [RelayCommand]
    public async Task LoadProductsAsync()
    {
        Products.Clear();

        var products = await _databaseService.Database.GetProductsAsync();

        foreach (var product in products)
        {
            Products.Add(product);
        }
    }

}
