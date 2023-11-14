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

    private void Crear_Clicked(object sender, EventArgs e)
    {

    }

    void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Cliente item = args.SelectedItem as Cliente;       

        Navigation.PushAsync(new DetalleClientePage(item, _servicioCliente));
    }
}