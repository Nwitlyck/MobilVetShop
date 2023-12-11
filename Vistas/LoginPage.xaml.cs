using MovilApp.IService;
using MovilApp.Servicios;

namespace MovilApp.Vistas;

public partial class LoginPage : ContentPage
{
    public LoginPage()
	{
		InitializeComponent();
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        var verify = await new ServiceUser(new GeneralAPI()).Verify(usuario.Text, contrasena.Text);

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