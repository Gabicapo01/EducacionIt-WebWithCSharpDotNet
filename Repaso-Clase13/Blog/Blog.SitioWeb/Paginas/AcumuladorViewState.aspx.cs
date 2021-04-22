using Blog.SitioWeb.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.SitioWeb.Paginas
{
    public partial class AcumuladorViewState : System.Web.UI.Page
    {
        private int contador = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Contador unContadorRetomadoDesdeViewState = (Contador)ViewState["contador"];
                contador = unContadorRetomadoDesdeViewState.Numero;
            }
            else
            {
                // Es la primera peticion
                Contador inicializoViewState = new Contador()
                {
                    Numero = 0
                };
                ViewState["contador"] = inicializoViewState;
            }
           
            // para usar el ViewState, el objeto/clase que uso tiene que estar marcada como serializable.
            // Serializable quiere decir que se puede convertir a un STRING. 
            // Se marca como [serializable] arriba de la clase entre parentesis.
            

        }

        protected void btnContador_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = $"{contador}";
            Contador unContador = new Contador() {
                Numero = contador
            };

            ViewState["contador"] = unContador;


            
            //Mecanismo para mantener el estado de la pagina: 1) ViewState

        }
    }
}