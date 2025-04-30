using ContactListApp.Views;

namespace ContactListApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("ContactsPage", typeof(ContactsPage));
            Routing.RegisterRoute("ContactDetailsPage", typeof(ContactDetailsPage));
        }

    }
    
}
