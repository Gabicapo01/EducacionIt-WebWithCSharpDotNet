using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void errorNivelPaginaSinTryCatch_Click(object sender, EventArgs e)
        {
            string temp="£$%432";
            int p = Convert.ToInt32(temp);
            
        }

        protected void errorNivelPaginaConTryCatch_Click(object sender, EventArgs e)
        {
            int numerador = 10;
            
            int denominador, cociente;
            // Trata de hacer una división
            try
            {
                Console.WriteLine("--> try");
                denominador = Convert.ToInt32(0.0000001);
                cociente = numerador / denominador;
                Console.WriteLine("Cociente = {0}", cociente);
            }
            // Atrapa excepción ArithmeticException
            catch (ArithmeticException arithmeticEx)
            {
                Server.Transfer("~/MostrarError.aspx?Ex="+arithmeticEx.Message);
                //lblTryCatch1.Text= "--> catch" + "Excepción aritmética" + "ArithmeticException Handler:" + arithmeticEx.ToString();
            }
            // Atrapa excepción ArgumentNullException
            catch (ArgumentNullException aNException)
            {
                Server.Transfer("~/MostrarError.aspx?Ex=" + aNException.Message);
                //Response.Redirect("MostrarError.aspx");
                //lblTryCatch2.Text = "--> catch" + "Excepción de argumento nulo" + "ArgumentNullException Handler: " + aNException.ToString();
            }
            // Atrapa excepción General
            catch (Exception exce)
            {
                Server.Transfer("~/MostrarError.aspx?Ex=" + exce.Message);
                //Response.Redirect("MostrarError.aspx");
                //lblTryCatch2.Text = "--> catch" + "generic Handler: " + exce.ToString();
            }
            finally
            {
                lblFinally.Text = "finally";
            }
        }

        protected void errorIIS_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaQueNoExiste.aspx");
        }

        private void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Session["Error"] = ex;
            Server.ClearError();
            Server.Transfer("~/MostrarError.aspx");
        }
    }
}