using MovilApp.Models;

namespace MovilApp.Models
{
    public class ResponseAppointmentsUpdate
    {
        public AppoinmentUpdate AppoinmentUpdate { get; set; } = new AppoinmentUpdate();
        public ResponseModel Errors { get; set; } = new ResponseModel();
    }
}
