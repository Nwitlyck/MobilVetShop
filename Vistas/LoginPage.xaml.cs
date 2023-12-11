using MovilApp.IService;

namespace MovilApp.Vistas;

public partial class LoginPage : ContentPage
{
    private readonly IServiceUsers _serviceUser;
    public LoginPage(IServiceUsers serviceUser)
	{
		InitializeComponent();
        _serviceUser = serviceUser;

    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        var verify = await _serviceUser.Verify(usuario.Text, contrasena.Text);

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