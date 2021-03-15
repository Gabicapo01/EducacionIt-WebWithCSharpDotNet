using Blog.Entidades;
using Blog.Entidades.Excepciones;
using Blog.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb.MasterPages
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        private readonly CategoriasNegocio categoriasNegocio = new CategoriasNegocio();


        protected void Page_Load(object sender, EventArgs e)
        {
            int contador = 1;

            // no es necesario si uso el GLOBAL.ASAX
            //if (Application["contador"] == null)
            //{
            //    Application["contador"] = 0;
            //}
            //else
            //{
            //    contador = (int)Application["contador"];
            //    contador++;
            //    Application["contador"] = contador;
            //}

            
            contador = (int)Application["contador"];
            contador++;
            Application["contador"] = contador;


            lblVisitas.Text = $"{contador}";

            if (!IsPostBack)
            {
                try 
                {
                    List<Categoria> categorias = categoriasNegocio.TodasLasCategoriasStoredProcedure();
                    lstCategorias.DataSource = categorias;
                    lstCategorias.DataBind(); // le dice que tome los elementos del DataSource y dibuje nuevamente la lista.
                }
                catch (CapaDatosException ex)
                {
                    pnlError.Visible = true;
                    lblErrorMessage.Text = ex.Message + " <br>" +ex.StackTrace;
                    //pnlError.GroupingText = ex.Message;
                }
                catch (ArgumentNullException ex)
                {
                    pnlError.Visible = true;
                    lblErrorMessage.Text = ex.Message + " <br>" + ex.StackTrace;
                }
                finally
                {

                }
                
            }

        }
    }
}