using Blog.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb.Administracion.BlogPost
{
    public partial class AdminBlogPostDefault : System.Web.UI.Page
    {
        private PostNegocio postNegocio = new PostNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstBlogPost.DataSource = postNegocio.TodosLosPosts();
                lstBlogPost.DataBind();
            }
        }
    }
}