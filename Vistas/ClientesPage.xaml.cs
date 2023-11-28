using MovilApp.IServicios;
using MovilApp.Modelos;


namespace MovilApp.Vistas;

public partial class ClientesPage : ContentPage
{
	private readonly IServicioCliente _servicioCliente;


	public ClientesPage(IServicioCliente servicioCliente)
	{
        InitializeComponent();
        _servicioCliente = servicioCliente;
		cargaclientes();
	}

	async void cargaclientes()
	{
		carga.IsVisible = true;

		var listaclientes = await _servicioCliente.ListaClientes();
		lvClientes.ItemsSource = listaclientes;
		carga.IsVisible = false;
	}

    private async void Crear_Clicked(object sender, EventArgs e)
    {
		Cliente cliente = new Cliente();
       await Navigation.PushAsync(new DetalleClientePage(cliente, _servicioCliente));
    }

    void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Cliente item = args.SelectedItem as Cliente;       

        Navigation.PushAsync(new DetalleClientePage(item, _servicioCliente));
    }
}