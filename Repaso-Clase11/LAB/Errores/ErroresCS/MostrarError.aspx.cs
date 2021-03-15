using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErroresCS
{
    public partial class MostrarError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Ex"] != null) 
            {
                this.lblMensaje.Text = Request.QueryString["Ex"];
            }
            else
            {
                if (Session["Error"] != null)
                {
                    Exception ex = (Exception)Session["Error"];
                    this.lblMensaje.Text = ex.StackTrace;
                    Session["Error"] = null;
                }
                else
                {
                    Response.Redirect("~/Default.aspx"); 
                }
            }  
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}