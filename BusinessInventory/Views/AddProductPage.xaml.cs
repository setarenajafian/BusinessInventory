using BusinessInventory.ViewModels;

namespace BusinessInventory.Views;

public partial class AddProductPage : ContentPage
{
	public AddProductPage(AddProductViewModel vm)
	{
        InitializeComponent();

        BindingContext = vm;
    }
}