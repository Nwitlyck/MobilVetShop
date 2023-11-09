namespace MovilApp.Vistas;

public partial class LogoutPage : ContentPage
{
	public LogoutPage()
	{
		InitializeComponent();
        SecureStorage.Remove("sesion");
        Shell.Current.GoToAsync("login");
    }
}