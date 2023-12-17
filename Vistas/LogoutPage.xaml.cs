using MovilApp.Servicios;

namespace MovilApp.Vistas;

public partial class LogoutPage : ContentPage
{
	public LogoutPage()
	{
		InitializeComponent();
        SecureStorage.RemoveAll();
        Shell.Current.GoToAsync("login");
        Application.Current.Quit();
    }
}