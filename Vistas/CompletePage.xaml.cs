using MovilApp.IService;
using MovilApp.Models;
using MovilApp.Servicios;

namespace MovilApp.Vistas;

public partial class CompletePage : ContentPage
{
    private readonly Appoiments _apoiment;
    private readonly IServiceAppointment _serviceAppointments;
    public CompletePage(/*IServiceAppointment serviceAppointment,*/ Appoiments appoiment)
    {
        InitializeComponent();
        _serviceAppointments = new ServiceAppoinment(new GeneralAPI())/*serviceAppointment*/;
        _apoiment = appoiment;
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        try
        {
            const int completeId = 91;

            var appoinmentUpdate = new AppoinmentUpdate { Id = _apoiment.Id, Description = entryMensaje.Text, State = completeId };

            await _serviceAppointments.UpdateAppointment(appoinmentUpdate);

            await DisplayAlert("Completado con exito", $"La cita se a completado de forma correcta", "OK");

            await Navigation.PopAsync();
        }
        catch
        {
            await DisplayAlert("No se a completado con exito", $"Hemos tenido problemas la cita no se a completado de forma correcta", "OK");
        }
        
    }
}