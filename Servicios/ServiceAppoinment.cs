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

        public Task<ResponseAppointmentsUpdate> UpdateAppointment(Appoiments appoiments)
        {
            throw new NotImplementedException();
        }
    }
}
