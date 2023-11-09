namespace MovilApp.Vistas;

public partial class CargaPage : ContentPage
{
	public CargaPage()
	{
		InitializeComponent();
	}
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (await estaAutenticado())
        {
            await Shell.Current.GoToAsync("///home");
        }
        else
        {
            await Shell.Current.GoToAsync("login");
        }
        base.OnNavigatedTo(args);
    }

    async Task<bool> estaAutenticado()
    {
        await Task.Delay(2000);
        var hasAuth = await SecureStorage.GetAsync("sesion");
        return !(hasAuth == null);
    }

}