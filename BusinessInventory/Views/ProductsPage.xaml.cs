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

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _viewModel.LoadProductsAsync();
    }

    
}