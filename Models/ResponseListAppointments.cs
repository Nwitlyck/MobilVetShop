using MovilApp.Models;

namespace MovilApp.Models
{
    public class ResponseListAppointments
    {
        public List<Appoiments> Appointmets { get; set; } = new List<Appoiments>();
        public ResponseModel Errors { get; set; } = new ResponseModel();
    }
}
