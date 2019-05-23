using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;


namespace Serviteca.PAGINASWEB
{
    public partial class LOGINVISTA : System.Web.UI.Page
    {
        private LOGINNEGOCIO obj = new LOGINNEGOCIO();



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnValidar_Click(object sender, EventArgs e)
        {
            string msg = "Usuario o clave invalido";

            int variableResultado = obj.ConsultarUsuario(txtUsuario.Text, txtClave.Text)

            if(variableResultado == 1)
            {
                msg = "Usuario Valido";
            }
            Label1.Text = msg;

        }
    }
}
