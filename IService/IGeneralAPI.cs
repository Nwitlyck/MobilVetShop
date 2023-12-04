using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.IService
{
    public interface IGeneralAPI
    {
        public HttpClient GetHttpClient();
        public string URL(string controller);
        
    }
}
