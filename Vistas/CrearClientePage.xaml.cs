/*using MovilApp.IServicios;
using MovilApp.Modelos;
*/
namespace MovilApp.Vistas;

public partial class CrearClientePage : ContentPage
{
    //private readonly IServicioCliente _servicioCliente;
    public CrearClientePage(/*IServicioCliente servicioCliente*/)
	{
		InitializeComponent();
        //_servicioCliente = servicioCliente;
	}
    /*
    async void InsertarCliente()
    {
        Cliente cliente = new Cliente()
        {
            Nombre = nombre.Text,
            Contacto = contacto.Text,
            Telefono = telefono.Text,
        };

        var responseCliente = await _servicioCliente.CrearCliente(cliente);
        if (responseCliente.errores.errorcode == 0)
        {
            await Navigation.PushAsync(new ClientesPage(_servicioCliente));
        }
        else
        {
            Mensaje.IsVisible = true;
            Mensaje.Text = "Error al crear el cliente";
        }
    }
    */
    private void Crear_Clicked(object sender, EventArgs e)
    {
        //InsertarCliente();
    }
}