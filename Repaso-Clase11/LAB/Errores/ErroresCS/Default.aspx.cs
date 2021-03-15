using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ErroresCS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnSinCapturar_Click(object sender, EventArgs e)
        {
            ErroresCS.Errores.Generar();
        }

        protected void btnCapturado_Click(object sender, EventArgs e)
        {
            try
            {
                ErroresCS.Errores.Generar();
            }
            catch (Exception ex)
            {
                Server.Transfer("~/MostrarError.aspx?Ex=" + ex.Message);
            }
        }

        protected void btnIIS_Click(object sender, EventArgs e)
        {
            Response.Redirect("paginaquenoexiste.aspx");
        }

        private void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Session["Error"] = ex;
            Server.ClearError();
            Server.Transfer("~/MostrarError.aspx");
        }
       
    }
}