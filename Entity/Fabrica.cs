using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Fabrica
    {
        public IConexion GetConexion(string baseDatos)
        {
            if(baseDatos.ToUpper() == "POSTGRESQL")
            {
                Postgresql instance = Postgresql.GetInstance();
                return instance;
            }else if(baseDatos.ToUpper() == "ORACLE")
            {
                Oracle instance = Oracle.GetInstance();
                return instance;
            }else
            {
                MySql instance = MySql.GetInstance();
                return instance;
            }
        }
    }
}
