//using MovilApp.IServicios;
using MovilApp.Models;
using System.Data.SqlTypes;
using System.Globalization;

namespace MovilApp.Vistas;

public partial class DetalleClientePage : ContentPage
{
    public DetalleClientePage(Appoiments appoiment)
    {
        InitializeComponent();
        cargainfo(appoiment);
    }

    async void cargainfo(Appoiments appoiment)
    {
        carga.IsVisible = true;
        List<Appoiments> listInfo = new List<Appoiments> { appoiment };
        lvInfo.ItemsSource = listInfo;

        carga.IsVisible = false;
    }

    private async void Volver_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}