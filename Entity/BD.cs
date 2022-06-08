using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BD
    {
        private string? host;
        private string? user;
        private string? password;
        private int? port;
        private string? database;

        public string? Host {
            get { return host; }
            set { if (value == "") { host = "local/host"; } else { host = value; } }
        }

        public string? User
        {
            get { return user; }
            set { if (value == "") { user = "userValido"; } else { user = value; } }
        }

        public string? Password
        {
            get { return password; }
            set { if (value == "") { password = "password"; } else { password = value; } }
        }

        public int? Port
        {
            get { return port; }
            set { if (value < 0) { port = 3307; } else { port = value; } }
        }
        public string? DataBase
        {
            get { return database; }
            set { if (value == "") { database = "dbPrueba"; } else { database = value; } }
        }
    }
}
