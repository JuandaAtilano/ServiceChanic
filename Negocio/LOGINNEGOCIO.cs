using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace NEGOCIO
{
    public class LOGINNEGOCIO
    {
        private LOGINDAO objDao = new LOGINDAO();

        public int ConsultarUsuario(string CLAVE, string NOMBREUSUARIO)
        {
            return objDao.ConsultarUsuario(CLAVE, NOMBREUSUARIO);
        }
    }
}