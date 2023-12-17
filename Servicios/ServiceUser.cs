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
        public async Task<Users> GetUsers(string email)
        {
            var client = _generalAPI.GetHttpClient();

            string result = await client.GetStringAsync(_generalAPI.URL("User") + "Select?email=" + email);
            var response = JsonConvert.DeserializeObject<ResponseUsers>(result);

            return response.User;
        }
        public async Task<ResponseVerify> Verify(LogIn logIn)
        {
            var client = _generalAPI.GetHttpClient();

            var mensage = new HttpRequestMessage(HttpMethod.Post, _generalAPI.URL("User") + "Verify");
            mensage.Content = JsonContent.Create<LogIn>(logIn);
            var response = await client.SendAsync(mensage);

            response.EnsureSuccessStatusCode();

            var verifyLogIn = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResponseVerify>(verifyLogIn);

        }
    }

}
