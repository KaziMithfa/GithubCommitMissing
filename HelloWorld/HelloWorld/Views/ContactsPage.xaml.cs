namespace HelloWorld.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        List<string> contacts = new List<string>()
        {
            "Anny",
            "Tuku",
            "Jwel",
            "Habib"
        };

        listContacts.ItemsSource = contacts;
	}

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }



    //private void btnAddContact_Clicked(object sender, EventArgs e)
    //{
    //    Shell.Current.GoToAsync(nameof(AddContactPage));

    //}

    //private void btnEditContact_Clicked(object sender, EventArgs e)
    //{
    //    Shell.Current.GoToAsync(nameof(EditContactPage));

    //}
}