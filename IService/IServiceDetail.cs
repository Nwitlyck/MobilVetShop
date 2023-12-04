using MovilApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.IService
{
    public interface IServiceDetail
    {
        public Task<List<Details>> ListDetails();
    }
}
