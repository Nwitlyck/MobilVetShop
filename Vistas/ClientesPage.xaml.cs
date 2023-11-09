using MovilApp.IServicios;

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

}