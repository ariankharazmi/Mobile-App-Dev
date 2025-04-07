using ContactListApp.ViewModels;

namespace ContactListApp.Views;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage(ContactViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}