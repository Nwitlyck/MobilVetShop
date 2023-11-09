using MovilApp.IServicios;
using MovilApp.Modelos;
using Newtonsoft.Json;

namespace MovilApp.Servicios
{

    public class ServicioCliente : IServicioCliente
    {
        private readonly IGeneralAPI _generalAPI;

        public ServicioCliente(IGeneralAPI generalAPI)
        {
            _generalAPI= generalAPI;
        }
        public async Task<List<Cliente>> ListaClientes()
        {
            var client = _generalAPI.GetHttpClient();

            string result = await client.GetStringAsync(_generalAPI.URL() + "listar");

            var resultado = JsonConvert.DeserializeObject<ResponseListaClientes>(result);

            var lista = resultado.clientes.ToList();

            return lista;
        }
    }
}
