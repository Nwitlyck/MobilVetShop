//using MovilApp.IServicios;
//using MovilApp.Modelos;

namespace MovilApp.Vistas;

public partial class DetalleClientePage : ContentPage
{
    //    private int id = 0;
    //    private readonly IServicioCliente _servicioCliente;\

    public class Info
    {
        public string CustomerName { get; set; }
        public string AsistantName { get; set; }
        public DateTime DateTime { get; set; }
        public string Address { get; set; }
        public string Canton { get; set; }
        public string Province { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
    }

    public DetalleClientePage(/*Cliente cliente, IServicioCliente servicioCliente*/)
	{
		InitializeComponent();
        cargainfo();
			
	}

    async void cargainfo()
    {
        carga.IsVisible = true;

        var listT = new List<Info>
        {
            new Info {
                CustomerName = "Pedro",
                AsistantName = "Test" ,
                DateTime = DateTime.Now ,
                Address = "Calle 9, casa 4e",
                Canton = "Santa Ana",
                Province = "San Jose",
                Description ="Grooming",
                State = 1},
            new Info {
                CustomerName = "Martin",
                AsistantName = "Test",
                Address = "Calle 9, casa 4e",
                Canton = "Santa Ana",
                Province = "Cartago",
                Description ="Checkeo anual",
                State = 1}
        };

        lvInfo.ItemsSource = listT;
        carga.IsVisible = false;
    }

    
    private async void Volver_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}