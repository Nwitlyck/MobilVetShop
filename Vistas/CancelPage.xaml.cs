using MovilApp.Models;
namespace MovilApp.Vistas;

public partial class CancelPage : ContentPage
{
    private readonly Appoiments appoiment;
    public CancelPage(Appoiments appoiment)
    {
		InitializeComponent();
        this.appoiment = appoiment;
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {

        string mensaje = entryMensaje.Text;

        await DisplayAlert("Mensaje Enviado", $"Mensaje: {mensaje}", "OK");

        appoiment.IsCompleted = true;

        await Navigation.PopAsync();
    }
}