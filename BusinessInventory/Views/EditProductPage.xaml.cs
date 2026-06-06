using BusinessInventory.ViewModels;

namespace BusinessInventory.Views;

public partial class EditProductPage : ContentPage
{
    public EditProductPage(EditProductViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}