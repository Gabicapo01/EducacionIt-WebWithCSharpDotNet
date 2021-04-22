using Blog.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb.Administracion.Categorias
{
    public partial class Default : System.Web.UI.Page
    {
        private CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstCategorias.DataSource = categoriasNegocio.TodasLasCategorias();
                lstCategorias.DataBind();
            }
        }
    }
}