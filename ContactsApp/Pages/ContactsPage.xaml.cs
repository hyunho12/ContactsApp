using ContactsApp.Repository;

namespace ContactsApp.Pages;

public partial class ContactsPage : ContentPage
{
    private ContactRepository _contactRepository;

	public ContactsPage()
	{
		InitializeComponent();
        GetAddressBook();
	}

    private void GetAddressBook()
    {
        //var addressBook = _contactRepository.getContacts;
        //CvData.ItemsSource = addressBook;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.Navigation.PushAsync(new AddContactPage());
    }

    private void btnTest_Clicked(object sender, EventArgs e)
    {

    }

    private void CvData_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if(CvData.SelectedItem != null)
        {
            Shell.Current.Navigation.PushAsync(new EditContactPage());
            ((CollectionView)sender).SelectedItem = null;
        }
        
    }
}