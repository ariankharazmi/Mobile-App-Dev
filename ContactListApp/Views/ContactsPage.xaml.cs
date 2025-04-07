using ContactListApp.ViewModels;

namespace ContactListApp.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage(ContactViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}