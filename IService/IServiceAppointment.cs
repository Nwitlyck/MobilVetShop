﻿using MovilApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.IService
{
    public interface IServiceAppointment    {
        public Task<List<Appoiments>> ListAppointments(string vetId);
        public Task<ResponseAppointmentsUpdate> UpdateAppointment(AppoinmentUpdate appoinmentUpdate);
    }
}
