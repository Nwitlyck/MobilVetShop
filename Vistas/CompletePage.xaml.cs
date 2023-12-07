using MovilApp.Models;

namespace MovilApp.Vistas;

public partial class CompletePage : ContentPage
{
    private readonly Appoiments appoiment;
    public CompletePage(Appoiments appoiment)
	{
		InitializeComponent();
        this.appoiment = appoiment;
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        
        string mensaje = entryMensaje.Text;

        await DisplayAlert("Mensaje Enviado", $"Mensaje: {mensaje}", "OK");

        await Navigation.PopAsync();
    }
}