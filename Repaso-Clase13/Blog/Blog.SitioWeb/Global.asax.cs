using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Blog.SitioWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["contador"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }
        // Esto esta en video CLASE 11- 1 hora 40 min en adelante.
        protected void Application_Error(object sender, EventArgs e)
        {   //esto le da un tratamiento a todos los errores que no fueron tratados anteriormente.
            Exception ex = Server.GetLastError();
            Server.ClearError(); // hace que quite la pagina amarilla del error de servidor.
            Server.Transfer("~/Error.aspx"); //me redirecciona a otra pagina, pero SIN CAMBIARME LA URL
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}