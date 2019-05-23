using System.Configuration;

namespace UTILIDADES
{
    public class CONEXION
    {
        public string CadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["Conexion"].ToString();
        }

    }

}
