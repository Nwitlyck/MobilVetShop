using MovilApp.IService;
using MovilApp.Models;
using MovilApp.Servicios;
namespace MovilApp.Vistas;

public partial class CancelPage : ContentPage
{
    private readonly Appoiments _appoiment;
    private readonly IServiceAppointment _serviceAppointments;
    public CancelPage(Appoiments appoiment)
    {
		InitializeComponent();
        _serviceAppointments = new ServiceAppoinment(new GeneralAPI())/*serviceAppointment*/;
        this._appoiment = appoiment;
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {

        const int completeId = 92;

        var appoinmentUpdate = new AppoinmentUpdate { Id = _appoiment.Id, Description = entryMensaje.Text, State = completeId };

        await _serviceAppointments.UpdateAppointment(appoinmentUpdate);

        await DisplayAlert("Solicitud cancelada exitosamente", "La cita se a cancelado de forma correcta", "OK");

        _appoiment.IsCompleted = true;

        await Navigation.PopAsync();
    }
}