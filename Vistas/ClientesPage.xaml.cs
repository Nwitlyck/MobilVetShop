
using MovilApp.IService;
using MovilApp.Models;

namespace MovilApp.Vistas;

public partial class ClientesPage : ContentPage
{

    private readonly IServiceAppointment _serviceAppointment;

    public ClientesPage(IServiceAppointment serviceAppointment/*, int vetId*/)
    {
        InitializeComponent();
        var vetId = 2;
        _serviceAppointment = serviceAppointment;
        cargaclientes(vetId);
    }

    async void cargaclientes(int vetId)
    {
        carga.IsVisible = true;

        var listAppoiments = await _serviceAppointment.ListAppointments(vetId);/*new List<Appoiments>
        {
            new Appoiments {
                CustomerName = "Pedro",
                AsistantName = "Test" ,
                DateTime = DateTime.Now ,
                Address = "Calle 9, casa 4e",
                Canton = "Santa Ana",
                Province = "San Jose",
                Description ="Grooming",
                State = 1},
            new Appoiments {
                CustomerName = "Martin",
                AsistantName = "Test",
                DateTime = DateTime.Now ,
                Address = "Calle 9, casa 4e",
                Canton = "Santa Ana",
                Province = "Cartago",
                Description ="Checkeo anual",
                State = 1}
        };*/
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