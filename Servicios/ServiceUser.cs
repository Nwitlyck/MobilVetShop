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

            string result = await client.GetStringAsync(_generalAPI.URL("User") + "Verify?email=" + email + "&password=" + password);
            var response = JsonConvert.DeserializeObject<ResponseVerify>(result);
            //var response = await client.SendAsync(mensaje);
            //response.EnsureSuccessStatusCode();

            //var verification = await response.Content.ReadAsStringAsync();

            return response;//JsonConvert.DeserializeObject<ResponseVerify>(verification);

        }
    }

}
