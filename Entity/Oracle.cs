using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Oracle : BD, IConexion
    {
        private static Oracle? instance;
        private Oracle() { }
        public static Oracle GetInstance()
        {
            if (instance == null)
            {
                return instance = new Oracle();
            }
            return instance;
        }
        public void Conectar()
        {
            Host = "local/hostOracle";
            User = "userOracle";
            Password = "passOracle";
            Port = 3303;
            DataBase = "ORACLE";

            Console.WriteLine("Conectando a la base de datos con el puerto: " + Port + " y el host: " + Host);
            Console.WriteLine("Base de datos: " + DataBase);
        }
    }
}
