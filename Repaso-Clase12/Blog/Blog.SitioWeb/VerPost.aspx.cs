using Blog.Entidades;
using Blog.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb
{
    public partial class VerPost : System.Web.UI.Page
    {
        private PostNegocio postNegocio = new PostNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idParametro = Request.QueryString["ID"];
                if (string.IsNullOrWhiteSpace(idParametro) == false)
                {
                    int id = Convert.ToInt32(idParametro);
                    BlogPost post = postNegocio.ObtenerPost(id);
                    lblTituloPost.Text = post.Titulo;
                    lblResumenPost.Text = post.Resumen;
                    lblCuerpo.Text = post.Cuerpo;
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
                
            }
        }

        protected void VolverButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }
    }
}