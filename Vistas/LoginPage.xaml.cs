using MovilApp.IService;
using MovilApp.Models;
using MovilApp.Servicios;

namespace MovilApp.Vistas;

public partial class LoginPage : ContentPage
{
    private readonly IServiceUsers _serviceUsers;
    public LoginPage(IServiceUsers serviceUsers)
	{
		InitializeComponent();
        _serviceUsers = serviceUsers;
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        var logIn = new LogIn { Email = usuario.Text, Password = contrasena.Text };
        var verify = await _serviceUsers.Verify(logIn);

        if (verify.Flag)
        {
            await SecureStorage.SetAsync("sesion", usuario.Text);
            await Shell.Current.GoToAsync("///home");
        }
        else
        {
            await DisplayAlert("Ingreso fallido", "Usuario o contraseña inválidos", "Pruebe de nuevo");
        }
    }
}