namespace MovilApp.Vistas;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (usuario.Text.Equals("admin") && contrasena.Text.Equals("123"))
        {
            await SecureStorage.SetAsync("sesion", "2");
            await Shell.Current.GoToAsync("///home");
        }
        else
        {
            await DisplayAlert("Ingreso fallido", "Usuario o contraseña inválidos", "Pruebe de nuevo");
        }
    }
}