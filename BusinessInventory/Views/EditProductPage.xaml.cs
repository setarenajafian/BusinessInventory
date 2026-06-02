using BusinessInventory.Models;
using BusinessInventory.ViewModels;

namespace BusinessInventory.Views;

public partial class EditProductPage : ContentPage
{
    public EditProductPage(
        EditProductViewModel viewModel,
        Product product)
    {
        InitializeComponent();

        viewModel.Load(product);

        BindingContext = viewModel;
    }
}