using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListApp.Models;
using System.Collections.ObjectModel;

using ContactListApp.Views;

namespace ContactListApp.ViewModels;

public partial class ContactViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<ContactListApp.Models.Contact> contacts = new();

    [ObservableProperty]
    private ContactListApp.Models.Contact selectedContact;

    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private string phoneNumber;

    [ObservableProperty]
    private string description;

    [ObservableProperty]
    private bool isEditing;

    [RelayCommand]
    async Task SaveContact()
    {
        var contact = new ContactListApp.Models.Contact
        {
            Name = Name,
            Email = Email,
            PhoneNumber = PhoneNumber,
            Description = Description
        };

        Contacts.Add(contact);
        ClearFields();
        await Shell.Current.GoToAsync("ContactsPage");
    }

    [RelayCommand]
    async Task ShowDetails(ContactListApp.Models.Contact contact)
    {
        SelectedContact = contact;
        await Shell.Current.GoToAsync(nameof(ContactDetailsPage));
    }

    [RelayCommand]
    async Task GoToAddContact()
    {
        await Shell.Current.GoToAsync("MainPage");
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    void ToggleEdit()
    {
        IsEditing = !IsEditing;
    }

    [RelayCommand]
    async Task SaveChanges()
    {
        IsEditing = false;
        await Shell.Current.GoToAsync("ContactDetailsPage");
    }

    private void ClearFields()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Description = string.Empty;
    }
}