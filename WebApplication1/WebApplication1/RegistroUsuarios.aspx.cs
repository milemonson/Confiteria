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
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargargrilla();
            }

        }
        private void cargargrilla()
        {
            List<Usuario> users = UsuarioBLL.CargarUser();
            gvUsuarios.DataSource = users;
            gvUsuarios.DataBind();
        }



        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                    Button btn = (Button)sender;
                    GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                    inputid.Text = gvr.Cells[0].Text;
                    inputuser.Text = gvr.Cells[1].Text;
                    inputpassword.Text = gvr.Cells[2].Text;
                    Deshabilitar();
                    btnModificar.Enabled = true;
                    btnCambios.Enabled = true;
                    btnEliminar.Enabled = true;
                    
            }
            catch (Exception)
            { 
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alert", "myerror1();", true);

            }

        }
            private void Deshabilitar()
            {
            inputuser.Enabled = false;
            inputpassword.Enabled = false;

            }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            inputuser.Enabled = true;
            inputpassword.Enabled = true;
            btnCambios.Enabled = true;
            btnEliminar.Enabled = true;
        }
        protected void btnCambios_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            if (ValidateUserModal() == true)
            {     
                try
                {
                    usu.idUser = int.Parse(inputid.Text);
                    usu.nameUser = inputuser.Text;
                    usu.password = inputpassword.Text;
                    usu.state =1;
                    UsuarioBLL.ActualizarUser(usu);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardocambios()", true);

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardaroncambios()", true);
                }
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            if (ValidateUserModal() == true)
            {    
                try
                {
                    usu.idUser = int.Parse(inputid.Text);
                    usu.nameUser = inputuser.Text;
                    usu.password = inputpassword.Text;
                    usu.state = 2;
                    UsuarioBLL.DeleteUser(usu);
                   
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminouser()", true);

                }
                catch (Exception )
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "nosepudoeliminar()", true);
                }

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            Usuario usu = new Usuario();

            if (ValidateUser() == true)
            {
                try
                {
                    usu.nameUser = inputnew1.Text;
                    usu.password = inputnew2.Text;
                    usu.state=1;
                    UsuarioBLL.NewUser(usu);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevoUser()", true);

                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseagregousuario()", true);
                }

            }
        }
        
        
       
        public bool ValidateUserModal()
        {
            if (inputuser.Text == "")
            {
                return false;
            }
            if (inputpassword.Text == "")
            {
                return false;
            }
            if (inputstate.Text == "1")
            {
                return false;
            }
            return true;
        }


        public bool ValidateUser()
        {
            if (inputnew1.Text == "")
            {
                return false;
            }
            if (inputnew2.Text == "")
            {
                return false;
            }
            if (inputnew3.Text == "1")
            {
                return false;
            }
            return true;
        }
    }


}
