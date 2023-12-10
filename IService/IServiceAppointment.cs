using MovilApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.IService
{
    public interface IServiceAppointment    {
        public Task<List<Appoiments>> ListAppointments(int vetId);
        public Task<ResponseAppointmentsUpdate> UpdateAppointment(Appoiments appoiments);
    }
}
