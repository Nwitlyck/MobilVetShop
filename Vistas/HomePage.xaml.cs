using MovilApp.IService;
using MovilApp.Servicios;

namespace MovilApp.Vistas;

public partial class HomePage : ContentPage
{
	private readonly IServiceUsers _serviceUsers;
	public HomePage(IServiceUsers serviceUsers)
	{
		InitializeComponent();
        _serviceUsers = serviceUsers;
        ViewProfile();
    }

    public async void ViewProfile()
    {
		var vetEmail = await SecureStorage.GetAsync("sesion");
        var users = await _serviceUsers.GetUsers(vetEmail);

		nombreLabel.Text = users.Name + " " + users.LastName;
		correoLabel.Text = users.Email;
		rolLabel.Text = users.Role;

	}
}