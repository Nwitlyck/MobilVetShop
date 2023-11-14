
using MovilApp.IServicios;
using MovilApp.Modelos;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MovilApp.Servicios
{

    public class ServicioCliente : IServicioCliente
    {
        private readonly IGeneralAPI _generalAPI;

        public ServicioCliente(IGeneralAPI generalAPI)
        {
            _generalAPI= generalAPI;
        }

        public async Task<ResponseCliente> ActualizarCliente(Cliente cliente)
        {
            var client = _generalAPI.GetHttpClient();

            var mensaje = new HttpRequestMessage(HttpMethod.Post, _generalAPI.URL("clientes") + "actualizar");
            mensaje.Content = JsonContent.Create<Cliente>(cliente);
            var response = await client.SendAsync(mensaje);
            response.EnsureSuccessStatusCode();

            var clienteActualizado = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResponseCliente>(clienteActualizado);


        }

        public async Task<List<Cliente>> ListaClientes()
        {
            var client = _generalAPI.GetHttpClient();

            string result = await client.GetStringAsync(_generalAPI.URL("clientes") + "listar");

            var resultado = JsonConvert.DeserializeObject<ResponseListaClientes>(result); 

            var lista = resultado.clientes.ToList();

            return lista;
        }
    }
}
