using MovilApp.IService;
using MovilApp.Models;
using MovilApp.Servicios;
namespace MovilApp.Vistas;

public partial class CancelPage : ContentPage
{
    private readonly Appoiments _appoiment;
    private readonly IServiceAppointment _serviceAppointments;
    public CancelPage(IServiceAppointment serviceAppointment, Appoiments appoiment)
    {
        InitializeComponent();
        _serviceAppointments = serviceAppointment;
        _appoiment = appoiment;
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {

        const int completeId = 92;

        var appoinmentUpdate = new AppoinmentUpdate { Id = _appoiment.Id, Description = entryMensaje.Text, State = completeId };

        await _serviceAppointments.UpdateAppointment(appoinmentUpdate);

        await DisplayAlert("Solicitud cancelada exitosamente", "La cita se a cancelado de forma correcta", "OK");

        await Navigation.PushAsync(new ClientesPage(_serviceAppointments));
    }
}