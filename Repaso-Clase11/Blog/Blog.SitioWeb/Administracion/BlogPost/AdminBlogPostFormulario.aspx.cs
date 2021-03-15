using Blog.Entidades;
using Blog.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb.Administracion.BlogPost
{
    public partial class AdminBlogPostFormulario : System.Web.UI.Page
    {
       
        private PostNegocio postNegocio = new PostNegocio();
        private CategoriasNegocio categoriasNegoc = new CategoriasNegocio();
        private string idParametro;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Categoria> dropdownCategorias = categoriasNegoc.TodasLasCategorias();
            
            idParametro = Request.QueryString["ID"];
            if(!string.IsNullOrWhiteSpace(idParametro) && !IsPostBack)
            {
                int id = Convert.ToInt32(idParametro);
                Entidades.BlogPost blogPost = postNegocio.ObtenerPost(id);
                lblId.Text = Convert.ToString(blogPost.Id);
                DropDownList.ClearSelection();
                DropDownList.SelectedValue = null;
               
                DropDownList.SelectedValue = Convert.ToString(blogPost.Categoria.Id);
                txtTitulo.Text = blogPost.Titulo;
                txtResumen.Text = blogPost.Resumen;
                txtCuerpo.Text = blogPost.Cuerpo;
                
            }
        }

        protected void btnGrabarPost_Click(object sender, EventArgs e)
        {
            //DropDownList.ClearSelection();

            if (!string.IsNullOrWhiteSpace(idParametro)) // si el IDPARAMETRO no esta VACIO, se esta actualizando
            {
                int id = Convert.ToInt32(idParametro);
                int idCategoria = Convert.ToInt32(DropDownList.SelectedValue);
                
                Entidades.BlogPost blogPostUI = new Entidades.BlogPost()
                {
                    Id = Convert.ToInt32(lblId.Text),
                    Categoria = categoriasNegoc.ObtenerCategoriaEF(idCategoria),
                    Titulo = txtTitulo.Text,
                    Resumen = txtResumen.Text,
                    Cuerpo = txtCuerpo.Text
                };

        bool resultadoActualizacion = postNegocio.Actualizar(blogPostUI);
                if (resultadoActualizacion == false)
                {
                    pnlError.Visible = true;
                }
                else
                {
                    Response.Redirect("AdminBlogPostDefault.aspx");
                }
            }
            else //SI el IDPARAMETRO esta vacio, entonces se esta creando
            {
                int idCategoria = Convert.ToInt32(DropDownList.SelectedValue);
                //var categoriaTempAAgregar = categoriasNegoc.ObtenerCategoriaEF(idCategoria);
                Entidades.BlogPost blogPostUI = new Entidades.BlogPost()
                {
                    Categoria = categoriasNegoc.ObtenerCategoriaEF(idCategoria),
                    Titulo = txtTitulo.Text,
                    Resumen = txtResumen.Text,
                    Cuerpo = txtCuerpo.Text
                };
                bool resultadoInsercion = postNegocio.InsertarPost(blogPostUI);
                if (resultadoInsercion == false)
                {
                    pnlError.Visible = true;
                }
                else
                {
                    Response.Redirect("AdminBlogPostDefault.aspx");
                }
            }
        }

        protected void VolverButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminBlogPostDefault.aspx");
        }




        protected void btnBorrarPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(idParametro))
            {
                int id = Convert.ToInt32(idParametro);
                bool resultadoActualizacion = postNegocio.Eliminar(id);
                if (resultadoActualizacion == false)
                {
                    pnlError.Visible = true;
                }
                else
                {
                    Response.Redirect("AdminBlogPostDefault.aspx");
                }
            }
        }
    }
}