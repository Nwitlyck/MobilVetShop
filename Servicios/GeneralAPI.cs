using MovilApp.IServicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.Servicios
{

    public class GeneralAPI : IGeneralAPI
    {

        static readonly string direccionbase = "http://10.0.2.2:5000";
        static readonly string _url = $"{direccionbase}/api/clientes/";

        public  HttpClient GetHttpClient()
        {
          
           var client = new HttpClient();
           //client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;

        }

        public string URL()
        {
            return _url;
        }
    }
}
