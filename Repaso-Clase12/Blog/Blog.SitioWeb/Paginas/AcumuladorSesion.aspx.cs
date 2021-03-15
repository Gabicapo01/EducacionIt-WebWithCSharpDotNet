using Blog.SitioWeb.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb.Paginas
{
    public partial class AcumuladorSesion : System.Web.UI.Page
    {
        private int contador = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["contador"]!=null)
            {
                Contador deSession = (Contador)Session["contador"];
                contador = deSession.Numero;
            }
            else
            {
                Contador inicializo = new Contador()
                {
                    Numero = 0
                };
            Session["contador"] = inicializo;
            }
            
        }

        protected void btnContador_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = $"{contador}";
            Contador unContador = new Contador()
            {
                Numero = contador
            };

            Session["contador"] = unContador;

            string Empresa = System.Configuration.ConfigurationManager.AppSettings["Empresa"];

            WebConfig.Text = Empresa;
        }
    }
}