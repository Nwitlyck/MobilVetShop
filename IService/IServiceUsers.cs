using MovilApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.IService
{
    public interface IServiceUsers
    {
        public Task<Users> GetUsers();
        public Task<ResponseVerify> Verify(string email, string password);
    }
}
