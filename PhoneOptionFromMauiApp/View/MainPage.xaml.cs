using PhoneOptionFromMauiApp.ViewModel;

namespace PhoneOptionFromMauiApp.View;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}

