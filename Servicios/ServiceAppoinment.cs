using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using MovilApp.IService;
using MovilApp.Models;

namespace MovilApp.Servicios
{
    public class ServiceAppoinment : IServiceAppointment
    {
        private readonly IGeneralAPI _generalAPI;
        public ServiceAppoinment(IGeneralAPI generalAPI)
        {
            _generalAPI = generalAPI;
        }
        public async Task<List<Appoiments>> ListAppointments(string vetId)
        {
            var client = _generalAPI.GetHttpClient();
            string result = await client.GetStringAsync(_generalAPI.URL("Appointments") + "List/?useremail=" + vetId);
            var response = JsonConvert.DeserializeObject<ResponseListAppointments>(result);
            return response.Appointmets.ToList();
        }

        public async Task<ResponseAppointmentsUpdate> UpdateAppointment(AppoinmentUpdate appoinmentUpdate)
        {
            var client = _generalAPI.GetHttpClient();

            var mensage = new HttpRequestMessage(HttpMethod.Put, _generalAPI.URL("Appointments") + "Update");
            mensage.Content = JsonContent.Create<AppoinmentUpdate>(appoinmentUpdate);
            var response = await client.SendAsync(mensage);

            response.EnsureSuccessStatusCode();

            var updatedApoinment = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResponseAppointmentsUpdate>(updatedApoinment);
        }
    }
}
