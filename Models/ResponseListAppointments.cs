using MovilApp.Models;

namespace MovilApp.Models
{
    public class ResponseListAppointments
    {
        public List<Appoiments> Appointmets { get; set; }
        public ResponseModel Errors { get; set; }
    }
}
