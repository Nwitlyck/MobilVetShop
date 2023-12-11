using MovilApp.IService;
using MovilApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.Servicios
{
    public class ServiceUser : IServiceUsers
    {
        private readonly IGeneralAPI _generalAPI;

        public ServiceUser(IGeneralAPI generalAPI)
        {
            _generalAPI = generalAPI;
        }
        public Task<Users> GetUsers()
        {
            throw new NotImplementedException();
        }
        public async Task<ResponseVerify> Verify(string email, string password)
        {
            var client = _generalAPI.GetHttpClient();

            var mensaje = new HttpRequestMessage(HttpMethod.Post, _generalAPI.URL("User") + "Verify");
            mensaje.Content = JsonContent.Create<string>(email);
            mensaje.Content = JsonContent.Create<string>(password);
            var response = await client.SendAsync(mensaje);
            response.EnsureSuccessStatusCode();

            var verification = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResponseVerify>(verification);

        }
    }

}
