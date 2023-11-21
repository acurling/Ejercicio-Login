using EJERCICIO5.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIO5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
           
        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            Clsusuario objusuario = new Clsusuario(tcorreo.Text, tclave.Text);  // instancia = copia de la clase
  
            if (Clsusuario.ValidarLogin()>0)
            {
                Response.Redirect("webform2.aspx");
            }
        }
    }
}