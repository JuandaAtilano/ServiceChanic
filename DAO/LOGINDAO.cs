using System;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;
using UTILIDADES;
using ENTIDADES;


namespace DAO
{
    public class LOGINDAO
    {
       
        int VARIABLERETORNO = 0;
        private CONEXION cadena = new CONEXION();
    //    private TABLAUSUARIO ObjTablaUsuario = new TABLAUSUARIO();


        public int ConsultarUsuario(string CLAVE, string NOMBREUSUARIO)
        {
            SqlDatabase db = new SqlDatabase(cadena.CadenaConexion());
            DbConnection conn = db.CreateConnection();
            DbCommand Comando = db.GetStoredProcCommand("ConsultarUsuario");
            db.AddInParameter(Comando, "@CLAVE", DbType.String, CLAVE);
            db.AddInParameter(Comando, "@NOMBREUSUARIO", DbType.String, NOMBREUSUARIO);

            try
            {
                IDataReader dr = db.ExecuteReader(Comando);

                while (dr.Read())
                {
                    VARIABLERETORNO = 1;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return VARIABLERETORNO;

        }
    }
}
