using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DatosDAL;
using ConexionBLL;

namespace PasteleriaProyect
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["NameUser"] = null;
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (inputuser.Text.Equals("") || inputpass.Text.Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "CompletarCampos()", true);
                return;
            }
            else
            {
                Usuario u = new Usuario();
                try
                {

                    string nameUser = inputuser.Text;
                    string password = inputpass.Text;
                    bool usuario = UsuarioBLL.ValidarUsuario(nameUser, password);
                   
                        if (usuario == true)
                        {
                        Session["NameUser"] = inputuser.Text;
                        Response.Redirect("index.aspx");

                        }
                        else
                        {
                            usuario = false;
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Popup", "NoRegitrado()", true);
                        }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

       
    }

}