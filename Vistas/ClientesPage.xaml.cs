
using MovilApp.Models;

namespace MovilApp.Vistas;

public partial class ClientesPage : ContentPage
{
	//private readonly IServicioCliente _servicioCliente;


	public ClientesPage(/*IServicioCliente servicioCliente*/)
	{
        InitializeComponent();
        //_servicioCliente = servicioCliente;
		cargaclientes();
	}

	async void cargaclientes()
	{
		carga.IsVisible = true;

        var listAppoiments = new List<Appoiments> 
        { 
            new Appoiments { 
                CustomerName = "Pedro", 
                UserName = "Test" , 
                DateTime = DateTime.Now ,
                Province = "A",
                State = 1},
            new Appoiments {
                CustomerName = "Martin",
                UserName = "Test" ,
                DateTime = DateTime.Now ,
                Province = "A",
                State = 1}
        }; //await _servicioCliente.ListaClientes();

        lvAppointments.ItemsSource = listAppoiments;
		carga.IsVisible = false;
	}

    private async void Crear_Clicked(object sender, EventArgs e)
    {
		
       //await Navigation.PushAsync(new CrearClientePage(_servicioCliente));
    }

    void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        //Appoiments item = args.SelectedItem as Appoiments;       

        //Navigation.PushAsync(new DetalleClientePage(item, _servicioCliente));
    }

    private async void OnInformacionClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new DetalleClientePage());
    }
}