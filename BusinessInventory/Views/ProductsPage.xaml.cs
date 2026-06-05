using BusinessInventory.Models;
using BusinessInventory.Services;
using BusinessInventory.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessInventory.Views;

public partial class ProductsPage : ContentPage
{
    private readonly ProductsViewModel _viewModel;
    private readonly ProductService _productService;


    public ProductsPage(
    ProductsViewModel viewModel,
    ProductService productService)
    {
        InitializeComponent();

        BindingContext = viewModel;

        _viewModel = viewModel;
        _productService = productService;
    }
    private async void OnAddProductClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Test", "Button Clicked", "OK");

        var page = IPlatformApplication.Current!.Services.GetRequiredService<AddProductPage>();

        await Navigation.PushAsync(page);
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (sender is not Button button)
            return;

        if (button.BindingContext is not Product product)
            return;

        bool result = await DisplayAlert(
            "Delete Product",
            $"Delete '{product.Name}' ?",
            "Yes",
            "No");

        if (!result)
            return;

        await _productService.DeleteAsync(product);

        await _viewModel.LoadProductsAsync();

        await DisplayAlert(
            "Success",
            "Product deleted successfully.",
            "OK");
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _viewModel.LoadProductsAsync();
    }

    
}