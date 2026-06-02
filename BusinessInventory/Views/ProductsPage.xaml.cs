using BusinessInventory.Models;
using BusinessInventory.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessInventory.Views;

public partial class ProductsPage : ContentPage
{
    private readonly ProductsViewModel _viewModel;

    public ProductsPage(ProductsViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
        _viewModel = viewModel;
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

        
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _viewModel.LoadProductsAsync();
    }

    
}