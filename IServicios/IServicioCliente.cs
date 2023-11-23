using MovilApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.IServicios
{
    public interface IServicioCliente
    {
        public Task<List<Cliente>> ListaClientes();
        public Task<ResponseCliente> ActualizarCliente(Cliente cliente);

        public Task<ResponseCliente> CrearCliente(Cliente cliente);
    }
}
