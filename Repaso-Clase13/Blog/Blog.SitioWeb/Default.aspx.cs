using Blog.Negocio;
using Blog.Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private PostNegocio postNegocio = new PostNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    lstPosts.DataSource = postNegocio.TodosLosPosts();
                    lstPosts.DataBind();
                }
                catch 
                {
                   //implemento este catch en la master page.
                    
                }
                
            }
        }
    }
}