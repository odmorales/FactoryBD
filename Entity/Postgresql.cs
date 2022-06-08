using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Postgresql : BD ,IConexion
    {
        private static Postgresql? instance;
        private Postgresql() { }

        public static Postgresql GetInstance()
        {
            if (instance == null)
            {
                return instance = new Postgresql();
            }
            return instance;
        }
        public void Conectar()
        {
            Host = "local/hostPostgresql";
            User = "userPostgresql";
            Password = "passPostgresql";
            Port = 3301;
            DataBase = "POSTGRESQL";

            Console.WriteLine("Conectando a la base de datos con el puerto: " + Port + " y el host: " + Host);
            Console.WriteLine("Base de datos: " + DataBase);
        }
    }
}
