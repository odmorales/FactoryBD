using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MySql : BD, IConexion
    {
        private static MySql? instance;
        private MySql() { }

        public static MySql GetInstance()
        {
            if (instance == null)
            {
                return instance = new MySql();
            }
            return instance;
        }
        public void Conectar()
        {
            Host = "local/hostMySql";
            User = "userMySqll";
            Password = "passMySql";
            Port = 3302;
            DataBase = "MYSQL";

            Console.WriteLine("Conectando a la base de datos con el puerto: " + Port + " y el host: " + Host);
            Console.WriteLine("Base de datos: " + DataBase);
        }
    }
}
