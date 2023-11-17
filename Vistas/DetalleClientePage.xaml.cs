using MovilApp.IServicios;
using MovilApp.Modelos;
using static Android.Content.ClipData;

namespace MovilApp.Vistas;

public partial class DetalleClientePage : ContentPage
{
    private int id = 0;
    private readonly IServicioCliente _servicioCliente;

    public DetalleClientePage(Cliente cliente, IServicioCliente servicioCliente)
	{
		InitializeComponent();
        _servicioCliente = servicioCliente;
        carga_datos(cliente);
			
	}

	void carga_datos(Cliente cliente)
	{
        
        nombre.Text = cliente.Nombre;
        telefono.Text = cliente.Telefono;
        contacto.Text = cliente.Contacto;
        id = cliente.Id;
     
    }

    async void ActualizarCliente()
    {
        Cliente cliente = new Cliente()
        {
            Nombre = nombre.Text,
            Telefono = telefono.Text,
            Contacto = contacto.Text,
            Id = id
        };

        var responseCliente = await _servicioCliente.ActualizarCliente(cliente);
        if (responseCliente.errores.errorcode==0)
        {
            await Navigation.PushAsync(new ClientesPage(_servicioCliente));
            
        }
        else
        {
            Mensaje.IsVisible = true;
            Mensaje.Text = "Error al actualizar el cliente";
        }
    }
    private void Actualizar_Clicked(object sender, EventArgs e)
    {
        ActualizarCliente();
    }
}