using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minggu2
{
    public class pengguna
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string JK { get; set; }
        public string Alamat { get; set; }

        public pengguna(string username, string password, string jK, string alamat)
        {
            Username = username;
            Password = password;
            JK = jK;
            Alamat = alamat;
        }
    }
}
