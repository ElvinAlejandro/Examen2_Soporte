using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Examen2_Soporte.Modelos.DAO
{
    //Almacena mi conexion de BD
    public class Conexion
    {
        protected SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["SoporteConexion"].ConnectionString);
    }
}
