using Blog.Entidades;
using Blog.Entidades.Excepciones;
using Blog.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilidades;
using Utilidades.Extension;

namespace Blog.SitioWeb.Administracion.Categorias
{
    public partial class Formulario : System.Web.UI.Page
    {
        private CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
        private string idParametro;

        protected void Page_Load(object sender, EventArgs e)
        {
            idParametro = Request.QueryString["ID"];
            int id = Conversiones.ToInt32(idParametro);
            if (id>0 && !IsPostBack)
            {
                
                    Categoria categoria = categoriasNegocio.ObtenerUnaCategoria(id);
                    txtNombre.Text = categoria.Nombre;
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            //idParametro = Request.QueryString["ID"]; // LEO el ID porque necesito decidir si va a actualizar o crear uno nuevo
            int id = idParametro.ToInt32();
            try
            {
                if (id>0) // si el IDPARAMETRO no esta VACIO, se esta actualizando
                {
                    categoriasNegocio.ActualizarCategoria(id, txtNombre.Text);
                    Response.Redirect("Default.aspx");
                    
                }
                else //SI el IDPARAMETRO esta vacio, entonces se esta creando
                {
                    categoriasNegocio.InsertarCategoria(txtNombre.Text);
                    Response.Redirect("Default.aspx");
                    
                }
            }
            catch (ValidacionNegocioException validationException)
            {
                pnlError.Visible = true;
                lblMensajeError.Text = validationException.Message;
            }
            catch (CapaDatosException capaDatosEx)
            {
                pnlError.Visible = true;
                lblMensajeError.Text = capaDatosEx.Message;

            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(idParametro))
            {
                int id = Convert.ToInt32(idParametro);
                bool resultadoActualizacion = categoriasNegocio.BorrarCategoria(id);
                if (resultadoActualizacion == false)
                {
                    pnlError.Visible = true;
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}