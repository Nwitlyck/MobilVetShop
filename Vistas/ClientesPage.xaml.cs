
using MovilApp.IService;
using MovilApp.Models;

namespace MovilApp.Vistas;

public partial class ClientesPage : ContentPage
{

    private readonly IServiceAppointment _serviceAppointment;

    public ClientesPage(IServiceAppointment serviceAppointment)
    {
        InitializeComponent();
        _serviceAppointment = serviceAppointment;
        cargaclientes();
    }

    async void cargaclientes()
    {
        carga.IsVisible = true;

        var vetEmail = await SecureStorage.GetAsync("sesion");
        var listAppoiments = await _serviceAppointment.ListAppointments(vetEmail);
        lvAppointments.ItemsSource = listAppoiments;
        carga.IsVisible = false;
    }


    private async void OnInformacionClicked(object sender, EventArgs e)
    {
        if (sender is MenuItem menuItem && menuItem.BindingContext is Appoiments appoiment)
        {
            await Navigation.PushAsync(new DetalleClientePage(appoiment));
        }
    }

    private async void OnCompleteClicked(object sender, EventArgs e)
    {


        if (lvAppointments.SelectedItem is Appoiments appoiment)
        {
            await Navigation.PushAsync(new CompletePage(appoiment));
        }
    }
    private async void OnReagendarClicked(object sender, EventArgs e)
    {


        if (lvAppointments.SelectedItem is Appoiments appoiment)
        {
            await Navigation.PushAsync(new ReagendarPage(appoiment));
        }
    }
    private async void OnCancelarClicked(object sender, EventArgs e)
    {


        if (lvAppointments.SelectedItem is Appoiments appoiment)
        {
            await Navigation.PushAsync(new CancelPage(appoiment));
        }
    }

}