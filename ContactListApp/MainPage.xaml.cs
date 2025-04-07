using ContactListApp.ViewModels;

namespace ContactListApp;

public partial class MainPage : ContentPage
{
    public MainPage(ContactViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}