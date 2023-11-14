using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.Modelos
{
    public  class ResponseCliente
    {
        public Cliente cliente { get; set; } = new Cliente();
        public ResponseModel errores { get; set; } = new ResponseModel();
    }
}
